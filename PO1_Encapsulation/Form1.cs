namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            joueur.PointDeVie = 10;
            monstre.PointDeVie = 30;
            joueur.Attaque = 1;
            monstre.Attaque = 3;
        }
        Personnage joueur = new Personnage();
        Personnage monstre = new Personnage();

        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            monstre.PointDeVie = monstre.PointDeVie - joueur.Attaque;
            joueur.PointDeVie = joueur.PointDeVie - monstre.Attaque;
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {

        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {

        }

       
    }
}