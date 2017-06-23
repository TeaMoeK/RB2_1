using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RB21
{
  public partial class Hauptfenster : Form
  {
    public Hauptfenster()
    {
      InitializeComponent();
    }

    private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void Hauptfenster_Load(object sender, EventArgs e)
    {
      // TODO: Diese Codezeile lädt Daten in die Tabelle "databaseDataSet.Personen". Sie können sie bei Bedarf verschieben oder entfernen.
      this.personenTableAdapter.Fill(this.databaseDataSet.Personen);

    }
  }
}
