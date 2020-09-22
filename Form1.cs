using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Hitoria
{
    public partial class Form1 : Form
    {
        string DirBase = "";
        string PathActuel = "";
        List<string> Historique = new List<string>();
        Dictionary<string, string> Elements = new Dictionary<string, string>();
        Dictionary<string, string> Modeles = new Dictionary<string, string>();
        
        public Form1()
        {
            InitializeComponent();
            bGO.Enabled = false;
            freeze(true);
            Console.WriteLine(System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]));
            string test = getLastOuverture();
            if(test != "")
            {
                ouvrirRep(test);
            }
        }
        

        string getLastOuverture()
        {
            string path = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            if (System.IO.File.Exists(path + "/TEMP.txt"))
            {
                return System.IO.File.ReadAllLines(path + "/TEMP.txt")[0];
            }
            else
            {
                return "";
            }
        }
        void setLastOuverture(string path_)
        {
            string path = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@path + "/TEMP.txt"))
            {
                file.Write(path_);
            }
        }
        private void SetModeles()
        {
            selecteurModeles.Items.Clear();
            foreach(string st in Modeles.Keys)
            {
                selecteurModeles.Items.Add(st);
            }
            selecteurModeles.SelectedIndex = 0;
        }
        private void SetElements()
        {
            selecteurDir.Items.Clear();
            foreach (string st in Elements.Keys)
            {
                selecteurDir.Items.Add(st);
            }
            
        }

        private void freeze(bool etat)
        {
            breload.Enabled = !etat;
            bouvrirword.Enabled = !etat;
            bSave.Enabled = !etat;
            bGO.Enabled = !etat;
            bretour.Enabled = !etat;
        }

        private void ouvrirRep(string Pth)
        {
            DirBase = "";
            PathActuel = "";
            Historique = new List<string>();
            Elements = new Dictionary<string, string>();
            Modeles = new Dictionary<string, string>();

            DirBase = Pth;
            Console.WriteLine(DirBase);
            if (!System.IO.Directory.Exists(DirBase + "/_modeles"))
            {
                System.IO.Directory.CreateDirectory(DirBase + "/_modeles");
                if (!System.IO.File.Exists(DirBase + "/start.rtf"))
                {
                    using (RichTextBox RTB = new RichTextBox())
                    {
                        RTB.Text = "";
                        RTB.SaveFile(DirBase + "/start.rtf", RichTextBoxStreamType.RichText);
                    }
                }
                if (!System.IO.File.Exists(DirBase + "/M0"))
                {
                    System.IO.Directory.CreateDirectory(DirBase + "/M0");
                }
                if (!System.IO.File.Exists(DirBase + "/_modeles/M0.rtf"))
                {
                    using (RichTextBox RTB = new RichTextBox())
                    {
                        RTB.Text = "";
                        RTB.SaveFile(DirBase + "/_modeles/M0.rtf", RichTextBoxStreamType.RichText);
                    }
                }
            }
            PathActuel = DirBase + "/start.rtf";
            string[] modeles = System.IO.Directory.GetFiles(DirBase + "/_modeles");
            foreach (string md in modeles)
            {
                Modeles.Add(System.IO.Path.GetFileNameWithoutExtension(md), md);
            }
            foreach (string pm in System.IO.Directory.GetDirectories(DirBase))
            {
                string dn = new System.IO.DirectoryInfo(pm).Name;
                if (!(dn[0] == '_'))
                {
                    string[] files = System.IO.Directory.GetFiles(pm);
                    foreach (string stf in files)
                    {
                        if (new System.IO.FileInfo(stf).Extension == ".rtf")
                        {
                            Elements.Add(System.IO.Path.GetFileNameWithoutExtension(stf), stf);
                        }
                    }
                }
            }
            Elements.Add("start", DirBase + "/start.rtf");
            AffichageTexte.LoadFile(PathActuel);
            SetModeles();
            SetElements();
            indicPosition.Text = System.IO.Path.GetFileNameWithoutExtension(PathActuel);
            freeze(false);
        }

        private void bOuvrirRep_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    ouvrirRep(fbd.SelectedPath);
                    setLastOuverture(fbd.SelectedPath);
                }
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            AffichageTexte.SaveFile(PathActuel);
        }

        private void bouvrirword_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(PathActuel);
        }
        private void reload()
        {
            string cdir = PathActuel;
            ouvrirRep(DirBase);
            PathActuel = cdir;
            AffichageTexte.LoadFile(PathActuel);
        }
        private void breload_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (selecteurDir.Text =="")
            {
                bGO.Enabled = false;
            }
            else
            {
                
                if (Elements.ContainsKey(selecteurDir.Text))
                {
                    bGO.Enabled = true;
                    bGO.Text = "Aller";
                }
                else
                {
                    if(selecteurModeles.SelectedIndex ==-1)
                    {
                        bGO.Enabled = false;
                    }
                    else
                    {
                        bGO.Enabled = true;
                    }
                    bGO.Text = "Creer";
                }
            }
        }

        private void AffichageTexte_SelectionChanged(object sender, EventArgs e)
        {
            selecteurDir.Text = AffichageTexte.SelectedText.Trim();
        }

        private void Avancer(bool creationAutorisee)
        {
            if (selecteurDir.Text != "")
            {
                AffichageTexte.SaveFile(PathActuel);
                string seltext = selecteurDir.Text.Trim();
                
                if (Elements.ContainsKey(seltext))
                {
                    Historique.Add(PathActuel);
                    PathActuel = Elements[seltext];
                    AffichageTexte.LoadFile(PathActuel);
                }
                else if (creationAutorisee)
                {
                    Historique.Add(PathActuel);
                    string name = seltext;
                    string model = (string)selecteurModeles.SelectedItem;
                    AffichageTexte.LoadFile(Modeles[model]);
                    if (!System.IO.Directory.Exists(Modeles[model]))
                    {
                        System.IO.Directory.CreateDirectory(DirBase + "/" + model);
                    }
                    string pathsave = DirBase + "/" + model + "/" + name + ".rtf";
                    PathActuel = pathsave;
                    AffichageTexte.SaveFile(pathsave);
                    Elements.Add(name, pathsave);
                    SetElements();
                }
                indicPosition.Text = System.IO.Path.GetFileNameWithoutExtension(PathActuel);
            }
        }

        private void bGO_Click(object sender, EventArgs e)
        {
            Avancer(true);
        }

        private void bretour_Click(object sender, EventArgs e)
        {
            if(Historique.Count != 0)
            {
                PathActuel = Historique[Historique.Count - 1];
                AffichageTexte.LoadFile(PathActuel);
                Historique.RemoveAt(Historique.Count - 1);
                indicPosition.Text = System.IO.Path.GetFileNameWithoutExtension(PathActuel);
            }
        }

        private void AffichageTexte_DoubleClick(object sender, EventArgs e)
        {
            
            Avancer(chbCreerAuto.Checked);
        }

        private void bRM_Click(object sender, EventArgs e)
        {
            if (PathActuel != DirBase + "/start.rtf")
            {
                if ((MessageBox.Show( "Voulez vous Oublier a jamais cette carte ?","Attention !",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {
                    supprimer();
                }
            }
        }
        
        void supprimer()
        {
            Elements.Remove(System.IO.Path.GetFileNameWithoutExtension(PathActuel));
            if (System.IO.File.Exists(PathActuel))
            {
                System.IO.File.Delete(PathActuel);
            }
            PathActuel = DirBase + "/start.rtf";
            AffichageTexte.LoadFile(PathActuel);
            indicPosition.Text = System.IO.Path.GetFileNameWithoutExtension(PathActuel);
            SetElements();
        }


    }
}
