using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanganronpaV3CoinEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkBackup_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Save files (*.dat)|*.dat|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtSavePath.Text = openFileDialog.FileName;
            }
        }
        private void btnBrowseOutput_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Save files (*.dat)|*.dat|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtOutputPath.Text = saveFileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sourcePath = txtSavePath.Text;
            string outputPath = txtOutputPath.Text;
            string coinText = txtCoinAmount.Text;
            string coinText2 = monocoinlabel.Text;
            string coinText3 = dclabel.Text;

            // Vérification des champs
            if (string.IsNullOrWhiteSpace(sourcePath) ||
                string.IsNullOrWhiteSpace(outputPath) ||
                (string.IsNullOrWhiteSpace(coinText) && actcasino.Checked) ||
                (string.IsNullOrWhiteSpace(coinText2) && monocoincheck.Checked) ||
                (string.IsNullOrWhiteSpace(coinText3) && dccheck.Checked))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (!(actcasino.Checked || monocoincheck.Checked ||dccheck.Checked))
            {
                MessageBox.Show("Please select at least one option");
                return;
            }
            // Vérifie si le nombre est valide
            if (!int.TryParse(coinText, out int coinAmount) || coinAmount < 0 || coinAmount > 999999999)
            {
                MessageBox.Show("Please enter a valid number of Casino coins (0 - 999999999).");
                return;
            }
            if (!int.TryParse(coinText2, out int coinAmount2) || coinAmount2 < 0 || coinAmount2 > 999)
            {
                MessageBox.Show("Please enter a valid number of Monocoins (0 - 999).");
                return;
            }
            if (!int.TryParse(coinText3, out int coinAmount3) || coinAmount3 < 0 || coinAmount3 > 999999)
            {
                MessageBox.Show("Please enter a valid number of GD Death card (0 - 999999).");
                return;
            }
            try
            {
                // Création d'une backup si demandé
                if (chkBackup.Checked)
                {
                    string backupPath = sourcePath + ".bak";
                    File.Copy(sourcePath, backupPath, true);
                }

                // Lit le fichier de sauvegarde
                byte[] saveData = File.ReadAllBytes(sourcePath);
                if (actcasino.Checked)
                {
                    // Trouve l'offset et la taille de la valeur des pièces (À MODIFIER SELON LA STRUCTURE DU FICHIER)
                    int coinOffset = 0xB458;
                    int coinSize = 4; // Remplacez par la taille correcte (généralement 4 bytes pour un entier)

                    // Convertit le nombre de pièces en tableau d'octets (Big Endian)
                    byte[] newCoinAmount = BitConverter.GetBytes(coinAmount);

                    // Copie les nouveaux octets dans le tableau de sauvegarde
                    Array.Copy(newCoinAmount, 0, saveData, coinOffset, coinSize);
                }
                if (monocoincheck.Checked)
                {
                    int coinOffset2 = 0x590;

                    // Monocoins = short (2 octets), little endian
                    short value = (short)coinAmount2;
                    byte[] newCoinAmount2 = BitConverter.GetBytes(value);

                    // Juste 2 octets
                    Array.Copy(newCoinAmount2, 0, saveData, coinOffset2, 2);

                    // Éventuellement aussi à 0x2BAE (comme dans le code original)
                    Array.Copy(newCoinAmount2, 0, saveData, 0x2BAE, 2);
                }
                if (dccheck.Checked)
                {
                    // Trouve l'offset et la taille de la valeur des pièces (À MODIFIER SELON LA STRUCTURE DU FICHIER)
                    int coinOffset3 = 0xB53C;
                    int coinSize3 = 4; // Remplacez par la taille correcte (généralement 4 bytes pour un entier)

                    // Convertit le nombre de pièces en tableau d'octets (Big Endian)
                    byte[] newCoinAmount3 = BitConverter.GetBytes(coinAmount3);

                    // Copie les nouveaux octets dans le tableau de sauvegarde
                    Array.Copy(newCoinAmount3, 0, saveData, coinOffset3, coinSize3);
                }
                // Écrit les données modifiées dans le fichier de sortie
                File.WriteAllBytes(outputPath, saveData);

                MessageBox.Show("Save modified!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CoinsCasinoEditor_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttontuto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here a tutorial :\nStep 1: choose the file with the button browse at the right of Original Save Path\nStep 2: choose the destination folder with the button browse at the right of Output Save Path(I recommend to choose the save file like the step 1 to just change it)\nStep 3 : select wich amount of coins you want to change :\n-Casino coins : 0-999999999\n-Monocoins : 0-999\n-Gold RPG Monokuma : 0-999999\nStep 4 : Choose if you want a backup (yes you want, really) (destination : same folder than the original save file)\nStep 5: Click create and play !");
        }
    }
}