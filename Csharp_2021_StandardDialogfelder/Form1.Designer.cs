
namespace Csharp_2021_StandardDialogfelder
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnOpenFileDialog = new System.Windows.Forms.Button();
			this.btnSaveFileDialog = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnOpenFileDialog
			// 
			this.btnOpenFileDialog.Location = new System.Drawing.Point(12, 12);
			this.btnOpenFileDialog.Name = "btnOpenFileDialog";
			this.btnOpenFileDialog.Size = new System.Drawing.Size(98, 23);
			this.btnOpenFileDialog.TabIndex = 0;
			this.btnOpenFileDialog.Text = "OpenFileDialog";
			this.btnOpenFileDialog.UseVisualStyleBackColor = true;
			this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
			// 
			// btnSaveFileDialog
			// 
			this.btnSaveFileDialog.Location = new System.Drawing.Point(125, 12);
			this.btnSaveFileDialog.Name = "btnSaveFileDialog";
			this.btnSaveFileDialog.Size = new System.Drawing.Size(105, 23);
			this.btnSaveFileDialog.TabIndex = 1;
			this.btnSaveFileDialog.Text = "SaveFileDialog";
			this.btnSaveFileDialog.UseVisualStyleBackColor = true;
			this.btnSaveFileDialog.Click += new System.EventHandler(this.btnSaveFileDialog_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(463, 52);
			this.Controls.Add(this.btnSaveFileDialog);
			this.Controls.Add(this.btnOpenFileDialog);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOpenFileDialog;
		private System.Windows.Forms.Button btnSaveFileDialog;
	}
}

