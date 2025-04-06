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

            // Vérification des champs
            if (string.IsNullOrWhiteSpace(sourcePath) ||
                string.IsNullOrWhiteSpace(outputPath) ||
                string.IsNullOrWhiteSpace(coinText))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Vérifie si le nombre est valide
            if (!int.TryParse(coinText, out int coinAmount) || coinAmount < 0 || coinAmount > 999999999)
            {
                MessageBox.Show("Please enter a valid number of coins (0 - 999999999).");
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

                // Trouve l'offset et la taille de la valeur des pièces (À MODIFIER SELON LA STRUCTURE DU FICHIER)
                int coinOffset = 0xB458;
                int coinSize = 4; // Remplacez par la taille correcte (généralement 4 bytes pour un entier)

                // Convertit le nombre de pièces en tableau d'octets (Big Endian)
                byte[] newCoinAmount = BitConverter.GetBytes(coinAmount);

                // Copie les nouveaux octets dans le tableau de sauvegarde
                Array.Copy(newCoinAmount, 0, saveData, coinOffset, coinSize);

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
    }
}