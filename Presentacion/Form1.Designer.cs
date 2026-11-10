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
            button1 = new Button();
            btnConsulta1 = new Button();
            consulta4btn = new Button();
            btnConsulta3 = new Button();
            SuspendLayout();
            // 
            // consulta6btn
            // 
            consulta6btn.Location = new Point(140, 473);
            consulta6btn.Margin = new Padding(4, 5, 4, 5);
            consulta6btn.Name = "consulta6btn";
            consulta6btn.Size = new Size(201, 50);
            consulta6btn.TabIndex = 0;
            consulta6btn.Text = "Consulta6";
            consulta6btn.UseVisualStyleBackColor = true;
            consulta6btn.Click += consulta6btn_Click;
            // 
            // consulta2btn
            // 
            consulta2btn.Location = new Point(140, 241);
            consulta2btn.Margin = new Padding(4, 5, 4, 5);
            consulta2btn.Name = "consulta2btn";
            consulta2btn.Size = new Size(201, 50);
            consulta2btn.TabIndex = 1;
            consulta2btn.Text = "Consulta 2";
            consulta2btn.UseVisualStyleBackColor = true;
            consulta2btn.Click += consulta2btn_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(140, 415);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(201, 50);
            button1.TabIndex = 2;
            button1.Text = "Consulta 5";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnConsulta1
            // 
            btnConsulta1.BackgroundImageLayout = ImageLayout.Center;
            btnConsulta1.Location = new Point(140, 183);
            btnConsulta1.Margin = new Padding(4, 5, 4, 5);
            btnConsulta1.Name = "btnConsulta1";
            btnConsulta1.Size = new Size(201, 50);
            btnConsulta1.TabIndex = 3;
            btnConsulta1.Text = "Consulta 1";
            btnConsulta1.UseVisualStyleBackColor = true;
            btnConsulta1.Click += btnConsulta1_Click;
            // 
            // consulta4btn
            // 
            consulta4btn.BackgroundImageLayout = ImageLayout.Center;
            consulta4btn.Location = new Point(140, 357);
            consulta4btn.Margin = new Padding(4, 5, 4, 5);
            consulta4btn.Name = "consulta4btn";
            consulta4btn.Size = new Size(201, 50);
            consulta4btn.TabIndex = 4;
            consulta4btn.Text = "Consulta 4";
            consulta4btn.UseVisualStyleBackColor = true;
            consulta4btn.Click += consulta4btn_Click;
            // 
            // btnConsulta3
            // 
            btnConsulta3.BackgroundImageLayout = ImageLayout.Center;
            btnConsulta3.Location = new Point(140, 299);
            btnConsulta3.Margin = new Padding(4, 5, 4, 5);
            btnConsulta3.Name = "btnConsulta3";
            btnConsulta3.Size = new Size(201, 50);
            btnConsulta3.TabIndex = 5;
            btnConsulta3.Text = "Consulta 3";
            btnConsulta3.UseVisualStyleBackColor = true;
            btnConsulta3.Click += btnConsulta3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnConsulta3);
            Controls.Add(consulta4btn);
            Controls.Add(btnConsulta1);
            Controls.Add(button1);
            Controls.Add(consulta2btn);
            Controls.Add(consulta6btn);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button consulta6btn;
        private Button consulta2btn;
        private Button button1;
        private Button btnConsulta1;
        private Button consulta4btn;
        private Button btnConsulta3;
    }
}
