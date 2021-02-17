using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_StandardDialogfelder
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnOpenFileDialog_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog()
			{
				Multiselect = true, // Multiselect = true : Auswahl von mehreren Dateien möglich
				InitialDirectory = @"C:\",  // Startverzeichnis
				Filter = "Tabellen (*.xlsx)|*.xslx|" +		// Filter
				" Texte (*.txt; *.docx)|*.txt; *.docx|" +
				" Alle Dateien (*.*)|*.*",
				Title = "Datei zum Öffnen auswählen"	// Titel
			};

			// OpenFileDialog anzeigen und Rückgabe auslesen
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				foreach (string s in ofd.FileNames)
				{
					Console.WriteLine("Öffnen: " + s);
				}
			}
			else
			{
				Console.WriteLine("Abbruch");
			}
		}

		private void btnSaveFileDialog_Click(object sender, EventArgs e)
		{
			// Objekt erstellen & initialisieren
			SaveFileDialog sfd = new SaveFileDialog()
			{
				InitialDirectory = @"C:\",
				Filter = "Tabellen (*.xlsx)|*.xslx|" +    // Filter
				" Texte (*.txt; *.docx)|*.txt; *.docx|" +
				" Alle Dateien (*.*)|*.*",
				Title = "Datei zum Speichern auswählen"
			};

			// SaveFileDialog anzeigen und Rückgabe auslesen
			if (sfd.ShowDialog() == DialogResult.OK) 
				Console.WriteLine("Speichern unter: " + sfd.FileName);
			else Console.WriteLine("Abbruch");
		}
	}
}
