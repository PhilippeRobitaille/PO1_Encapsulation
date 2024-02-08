using System.Runtime.InteropServices;

namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur = new();
        Personnage dragon = new();
        public Form1()
        {
            InitializeComponent();
            joueur.PointDeVie = 10;
            joueur.PointsDePuissance = 1;

            dragon.PointDeVie = joueur.PointDeVie * 3;
            dragon.PointsDePuissance = joueur.PointsDePuissance * 3;

        }

        private void ActualiserLabels()
        {
            lbl_pointsVieJoueur.Text = " Vie du joueur : " + joueur.PointDeVie.ToString();
            lbl_pointsVieDragon.Text = " Vie du dragon : " + dragon.PointDeVie.ToString();
            lbl_puissanceAttaqueJoueur.Text = " Attaque du joueur " + joueur.PointsDePuissance.ToString();
            lbl_puissanceAttaqueDragon.Text = " Attaque du dragon " + dragon.PointsDePuissance.ToString();
        }

        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            dragon.PointDeVie -= joueur.PointsDePuissance;
            ActualiserLabels();
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            ActualiserLabels();
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {
            ActualiserLabels();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualiserLabels();
        }
    }
}