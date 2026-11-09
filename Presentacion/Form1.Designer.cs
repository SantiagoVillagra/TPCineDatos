namespace Cine_proyecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            consulta6btn = new Button();
            consulta2btn = new Button();
            SuspendLayout();
            // 
            // consulta6btn
            // 
            consulta6btn.Location = new Point(98, 120);
            consulta6btn.Name = "consulta6btn";
            consulta6btn.Size = new Size(141, 30);
            consulta6btn.TabIndex = 0;
            consulta6btn.Text = "Consulta6";
            consulta6btn.UseVisualStyleBackColor = true;
            consulta6btn.Click += consulta6btn_Click;
            // 
            // consulta2btn
            // 
            consulta2btn.Location = new Point(98, 183);
            consulta2btn.Name = "consulta2btn";
            consulta2btn.Size = new Size(141, 30);
            consulta2btn.TabIndex = 1;
            consulta2btn.Text = "Consulta 2";
            consulta2btn.UseVisualStyleBackColor = true;
            consulta2btn.Click += consulta2btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(consulta2btn);
            Controls.Add(consulta6btn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button consulta6btn;
        private Button consulta2btn;
    }
}
