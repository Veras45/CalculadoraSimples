
namespace CalculadoraSimples
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btsoma = new System.Windows.Forms.Button();
            this.btsubtracao = new System.Windows.Forms.Button();
            this.btmultiplicacao = new System.Windows.Forms.Button();
            this.btdivisao = new System.Windows.Forms.Button();
            this.lbresultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(103, 13);
            this.txtValorA.Margin = new System.Windows.Forms.Padding(6);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(145, 29);
            this.txtValorA.TabIndex = 2;
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(103, 54);
            this.txtValorB.Margin = new System.Windows.Forms.Padding(6);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(145, 29);
            this.txtValorB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor A:";
            // 
            // btsoma
            // 
            this.btsoma.BackColor = System.Drawing.Color.PaleGreen;
            this.btsoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsoma.Location = new System.Drawing.Point(119, 98);
            this.btsoma.Margin = new System.Windows.Forms.Padding(6);
            this.btsoma.Name = "btsoma";
            this.btsoma.Size = new System.Drawing.Size(37, 34);
            this.btsoma.TabIndex = 5;
            this.btsoma.Text = "+";
            this.btsoma.UseVisualStyleBackColor = false;
            this.btsoma.Click += new System.EventHandler(this.btOperacao_Click);
            // 
            // btsubtracao
            // 
            this.btsubtracao.BackColor = System.Drawing.SystemColors.Info;
            this.btsubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsubtracao.Location = new System.Drawing.Point(184, 98);
            this.btsubtracao.Margin = new System.Windows.Forms.Padding(6);
            this.btsubtracao.Name = "btsubtracao";
            this.btsubtracao.Size = new System.Drawing.Size(39, 34);
            this.btsubtracao.TabIndex = 6;
            this.btsubtracao.Text = "-";
            this.btsubtracao.UseVisualStyleBackColor = false;
            this.btsubtracao.Click += new System.EventHandler(this.btOperacao_Click);
            // 
            // btmultiplicacao
            // 
            this.btmultiplicacao.BackColor = System.Drawing.Color.IndianRed;
            this.btmultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmultiplicacao.Location = new System.Drawing.Point(119, 135);
            this.btmultiplicacao.Margin = new System.Windows.Forms.Padding(6);
            this.btmultiplicacao.Name = "btmultiplicacao";
            this.btmultiplicacao.Size = new System.Drawing.Size(37, 31);
            this.btmultiplicacao.TabIndex = 7;
            this.btmultiplicacao.Text = "X";
            this.btmultiplicacao.UseVisualStyleBackColor = false;
            this.btmultiplicacao.Click += new System.EventHandler(this.btOperacao_Click);
            // 
            // btdivisao
            // 
            this.btdivisao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btdivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdivisao.Location = new System.Drawing.Point(184, 135);
            this.btdivisao.Margin = new System.Windows.Forms.Padding(6);
            this.btdivisao.Name = "btdivisao";
            this.btdivisao.Size = new System.Drawing.Size(39, 31);
            this.btdivisao.TabIndex = 8;
            this.btdivisao.Text = "÷";
            this.btdivisao.UseVisualStyleBackColor = false;
            this.btdivisao.Click += new System.EventHandler(this.btOperacao_Click);
            // 
            // lbresultado
            // 
            this.lbresultado.Location = new System.Drawing.Point(19, 213);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(268, 97);
            this.lbresultado.TabIndex = 9;
            this.lbresultado.Text = ".";
            this.lbresultado.Click += new System.EventHandler(this.lbresultado_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Valor B:";
            // 
            // btlimpar
            // 
            this.btlimpar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btlimpar.ForeColor = System.Drawing.Color.Red;
            this.btlimpar.Location = new System.Drawing.Point(40, 98);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(75, 68);
            this.btlimpar.TabIndex = 11;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = false;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(318, 319);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbresultado);
            this.Controls.Add(this.btdivisao);
            this.Controls.Add(this.btmultiplicacao);
            this.Controls.Add(this.btsubtracao);
            this.Controls.Add(this.btsoma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.txtValorA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormPrincipal";
            this.Text = "Calculadora Simples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btsoma;
        private System.Windows.Forms.Button btsubtracao;
        private System.Windows.Forms.Button btmultiplicacao;
        private System.Windows.Forms.Button btdivisao;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btlimpar;
    }
}

