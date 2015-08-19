namespace RCE
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupboxControles = new System.Windows.Forms.GroupBox();
            this.btnIniciarRegistrar = new System.Windows.Forms.Button();
            this.btnPararRegistrar = new System.Windows.Forms.Button();
            this.groupboxConfig = new System.Windows.Forms.GroupBox();
            this.numTempoBuffer = new System.Windows.Forms.NumericUpDown();
            this.lblTempoBuffer = new System.Windows.Forms.Label();
            this.btnAlterarLocalGravacao = new System.Windows.Forms.Button();
            this.txtLocalGravacao = new System.Windows.Forms.TextBox();
            this.lblOndeSalvar = new System.Windows.Forms.Label();
            this.tooltipImportante = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipComum = new System.Windows.Forms.ToolTip(this.components);
            this.groupboxControles.SuspendLayout();
            this.groupboxConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTempoBuffer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupboxControles
            // 
            this.groupboxControles.Controls.Add(this.btnPararRegistrar);
            this.groupboxControles.Controls.Add(this.btnIniciarRegistrar);
            this.groupboxControles.Location = new System.Drawing.Point(12, 12);
            this.groupboxControles.Name = "groupboxControles";
            this.groupboxControles.Size = new System.Drawing.Size(360, 121);
            this.groupboxControles.TabIndex = 0;
            this.groupboxControles.TabStop = false;
            this.groupboxControles.Text = "Controles principais";
            // 
            // btnIniciarRegistrar
            // 
            this.btnIniciarRegistrar.Location = new System.Drawing.Point(6, 19);
            this.btnIniciarRegistrar.Name = "btnIniciarRegistrar";
            this.btnIniciarRegistrar.Size = new System.Drawing.Size(348, 45);
            this.btnIniciarRegistrar.TabIndex = 0;
            this.btnIniciarRegistrar.Text = "Iniciar";
            this.tooltipComum.SetToolTip(this.btnIniciarRegistrar, "Iniciar registro de entrada");
            this.btnIniciarRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnPararRegistrar
            // 
            this.btnPararRegistrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPararRegistrar.Location = new System.Drawing.Point(6, 70);
            this.btnPararRegistrar.Name = "btnPararRegistrar";
            this.btnPararRegistrar.Size = new System.Drawing.Size(348, 45);
            this.btnPararRegistrar.TabIndex = 1;
            this.btnPararRegistrar.Text = "Parar";
            this.tooltipComum.SetToolTip(this.btnPararRegistrar, "Parar de registrar");
            this.btnPararRegistrar.UseVisualStyleBackColor = true;
            // 
            // groupboxConfig
            // 
            this.groupboxConfig.Controls.Add(this.lblOndeSalvar);
            this.groupboxConfig.Controls.Add(this.txtLocalGravacao);
            this.groupboxConfig.Controls.Add(this.btnAlterarLocalGravacao);
            this.groupboxConfig.Controls.Add(this.lblTempoBuffer);
            this.groupboxConfig.Controls.Add(this.numTempoBuffer);
            this.groupboxConfig.Location = new System.Drawing.Point(12, 139);
            this.groupboxConfig.Name = "groupboxConfig";
            this.groupboxConfig.Size = new System.Drawing.Size(360, 100);
            this.groupboxConfig.TabIndex = 1;
            this.groupboxConfig.TabStop = false;
            this.groupboxConfig.Text = "Configurações";
            // 
            // numTempoBuffer
            // 
            this.numTempoBuffer.Location = new System.Drawing.Point(155, 14);
            this.numTempoBuffer.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numTempoBuffer.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numTempoBuffer.Name = "numTempoBuffer";
            this.numTempoBuffer.Size = new System.Drawing.Size(40, 20);
            this.numTempoBuffer.TabIndex = 2;
            this.numTempoBuffer.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblTempoBuffer
            // 
            this.lblTempoBuffer.AutoSize = true;
            this.lblTempoBuffer.Location = new System.Drawing.Point(6, 16);
            this.lblTempoBuffer.Name = "lblTempoBuffer";
            this.lblTempoBuffer.Size = new System.Drawing.Size(143, 13);
            this.lblTempoBuffer.TabIndex = 3;
            this.lblTempoBuffer.Text = "Tempo do buffer (segundos):";
            this.tooltipImportante.SetToolTip(this.lblTempoBuffer, resources.GetString("lblTempoBuffer.ToolTip"));
            // 
            // btnAlterarLocalGravacao
            // 
            this.btnAlterarLocalGravacao.Location = new System.Drawing.Point(279, 46);
            this.btnAlterarLocalGravacao.Name = "btnAlterarLocalGravacao";
            this.btnAlterarLocalGravacao.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarLocalGravacao.TabIndex = 2;
            this.btnAlterarLocalGravacao.Text = "Alterar...";
            this.btnAlterarLocalGravacao.UseVisualStyleBackColor = true;
            // 
            // txtLocalGravacao
            // 
            this.txtLocalGravacao.Location = new System.Drawing.Point(79, 47);
            this.txtLocalGravacao.Name = "txtLocalGravacao";
            this.txtLocalGravacao.ReadOnly = true;
            this.txtLocalGravacao.Size = new System.Drawing.Size(194, 20);
            this.txtLocalGravacao.TabIndex = 4;
            this.tooltipImportante.SetToolTip(this.txtLocalGravacao, "Local onde serão armazenados os arquivos gerados.");
            // 
            // lblOndeSalvar
            // 
            this.lblOndeSalvar.AutoSize = true;
            this.lblOndeSalvar.Location = new System.Drawing.Point(6, 50);
            this.lblOndeSalvar.Name = "lblOndeSalvar";
            this.lblOndeSalvar.Size = new System.Drawing.Size(67, 13);
            this.lblOndeSalvar.TabIndex = 5;
            this.lblOndeSalvar.Text = "Onde salvar:";
            // 
            // tooltipImportante
            // 
            this.tooltipImportante.AutomaticDelay = 300;
            this.tooltipImportante.AutoPopDelay = 5000;
            this.tooltipImportante.InitialDelay = 300;
            this.tooltipImportante.IsBalloon = true;
            this.tooltipImportante.ReshowDelay = 100;
            // 
            // tooltipComum
            // 
            this.tooltipComum.AutoPopDelay = 5000;
            this.tooltipComum.InitialDelay = 300;
            this.tooltipComum.ReshowDelay = 100;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnIniciarRegistrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnPararRegistrar;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.groupboxConfig);
            this.Controls.Add(this.groupboxControles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REC";
            this.groupboxControles.ResumeLayout(false);
            this.groupboxConfig.ResumeLayout(false);
            this.groupboxConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTempoBuffer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxControles;
        private System.Windows.Forms.Button btnPararRegistrar;
        private System.Windows.Forms.Button btnIniciarRegistrar;
        private System.Windows.Forms.GroupBox groupboxConfig;
        private System.Windows.Forms.Label lblTempoBuffer;
        private System.Windows.Forms.NumericUpDown numTempoBuffer;
        private System.Windows.Forms.Label lblOndeSalvar;
        private System.Windows.Forms.TextBox txtLocalGravacao;
        private System.Windows.Forms.ToolTip tooltipImportante;
        private System.Windows.Forms.Button btnAlterarLocalGravacao;
        private System.Windows.Forms.ToolTip tooltipComum;
    }
}

