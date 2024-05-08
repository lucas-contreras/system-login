namespace System.Login.Presentation
{
    partial class frmConfiguration
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
            gbConfig = new GroupBox();
            mkQuantityBeforeBlock = new MaskedTextBox();
            lblRestartAfter = new Label();
            mkRestartBefore = new MaskedTextBox();
            chAllowAutoUnlock = new CheckBox();
            lblAttemptsToLogin = new Label();
            chAllowOldPass = new CheckBox();
            chReqConfSecQuestions = new CheckBox();
            chReq2FA = new CheckBox();
            chReqAtLeast1Sp = new CheckBox();
            chReqNumAndLet = new CheckBox();
            chMayusAndMin = new CheckBox();
            chMinCharacters = new CheckBox();
            btnSave = new Button();
            btnCancelar = new Button();
            gbConfig.SuspendLayout();
            SuspendLayout();
            // 
            // gbConfig
            // 
            gbConfig.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbConfig.Controls.Add(mkQuantityBeforeBlock);
            gbConfig.Controls.Add(lblRestartAfter);
            gbConfig.Controls.Add(mkRestartBefore);
            gbConfig.Controls.Add(chAllowAutoUnlock);
            gbConfig.Controls.Add(lblAttemptsToLogin);
            gbConfig.Controls.Add(chAllowOldPass);
            gbConfig.Controls.Add(chReqConfSecQuestions);
            gbConfig.Controls.Add(chReq2FA);
            gbConfig.Controls.Add(chReqAtLeast1Sp);
            gbConfig.Controls.Add(chReqNumAndLet);
            gbConfig.Controls.Add(chMayusAndMin);
            gbConfig.Controls.Add(chMinCharacters);
            gbConfig.Location = new Point(12, 12);
            gbConfig.Name = "gbConfig";
            gbConfig.Size = new Size(483, 296);
            gbConfig.TabIndex = 0;
            gbConfig.TabStop = false;
            // 
            // mkQuantityBeforeBlock
            // 
            mkQuantityBeforeBlock.Location = new Point(315, 196);
            mkQuantityBeforeBlock.Mask = "00";
            mkQuantityBeforeBlock.Name = "mkQuantityBeforeBlock";
            mkQuantityBeforeBlock.Size = new Size(33, 23);
            mkQuantityBeforeBlock.TabIndex = 8;
            mkQuantityBeforeBlock.Text = "3";
            mkQuantityBeforeBlock.ValidatingType = typeof(int);
            // 
            // lblRestartAfter
            // 
            lblRestartAfter.AutoSize = true;
            lblRestartAfter.Location = new Point(50, 253);
            lblRestartAfter.Name = "lblRestartAfter";
            lblRestartAfter.Size = new Size(122, 15);
            lblRestartAfter.TabIndex = 12;
            lblRestartAfter.Text = "Se reiniciará luego de:";
            // 
            // mkRestartBefore
            // 
            mkRestartBefore.Enabled = false;
            mkRestartBefore.Location = new Point(186, 250);
            mkRestartBefore.Mask = "00:00";
            mkRestartBefore.Name = "mkRestartBefore";
            mkRestartBefore.Size = new Size(39, 23);
            mkRestartBefore.TabIndex = 11;
            mkRestartBefore.Text = "0000";
            mkRestartBefore.ValidatingType = typeof(DateTime);
            // 
            // chAllowAutoUnlock
            // 
            chAllowAutoUnlock.AutoSize = true;
            chAllowAutoUnlock.Location = new Point(18, 225);
            chAllowAutoUnlock.Name = "chAllowAutoUnlock";
            chAllowAutoUnlock.Size = new Size(380, 19);
            chAllowAutoUnlock.TabIndex = 9;
            chAllowAutoUnlock.Text = "Desbloqueo automatico del usuario luego de un horario especifico.";
            chAllowAutoUnlock.UseVisualStyleBackColor = true;
            chAllowAutoUnlock.CheckedChanged += chAllowAutoUnlock_CheckedChanged;
            // 
            // lblAttemptsToLogin
            // 
            lblAttemptsToLogin.AutoSize = true;
            lblAttemptsToLogin.Location = new Point(14, 199);
            lblAttemptsToLogin.Name = "lblAttemptsToLogin";
            lblAttemptsToLogin.Size = new Size(271, 15);
            lblAttemptsToLogin.TabIndex = 8;
            lblAttemptsToLogin.Text = "Cantidad de intentos antes de bloquear al usuario:";
            // 
            // chAllowOldPass
            // 
            chAllowOldPass.AutoSize = true;
            chAllowOldPass.Location = new Point(18, 172);
            chAllowOldPass.Name = "chAllowOldPass";
            chAllowOldPass.Size = new Size(253, 19);
            chAllowOldPass.TabIndex = 7;
            chAllowOldPass.Text = "Permite contraseñas usadas anteriormente.";
            chAllowOldPass.UseVisualStyleBackColor = true;
            // 
            // chReqConfSecQuestions
            // 
            chReqConfSecQuestions.AutoSize = true;
            chReqConfSecQuestions.Location = new Point(18, 147);
            chReqConfSecQuestions.Name = "chReqConfSecQuestions";
            chReqConfSecQuestions.Size = new Size(412, 19);
            chReqConfSecQuestions.TabIndex = 6;
            chReqConfSecQuestions.Text = "Requiere configurar preguntas de seguridad para recuperar la contraseña.";
            chReqConfSecQuestions.UseVisualStyleBackColor = true;
            // 
            // chReq2FA
            // 
            chReq2FA.AutoSize = true;
            chReq2FA.Location = new Point(18, 122);
            chReq2FA.Name = "chReq2FA";
            chReq2FA.Size = new Size(97, 19);
            chReq2FA.TabIndex = 5;
            chReq2FA.Text = "Requiere 2FA.";
            chReq2FA.UseVisualStyleBackColor = true;
            // 
            // chReqAtLeast1Sp
            // 
            chReqAtLeast1Sp.AutoSize = true;
            chReqAtLeast1Sp.Location = new Point(18, 97);
            chReqAtLeast1Sp.Name = "chReqAtLeast1Sp";
            chReqAtLeast1Sp.Size = new Size(225, 19);
            chReqAtLeast1Sp.TabIndex = 4;
            chReqAtLeast1Sp.Text = "Requiere al menos 1 cáracter especial.";
            chReqAtLeast1Sp.UseVisualStyleBackColor = true;
            // 
            // chReqNumAndLet
            // 
            chReqNumAndLet.AutoSize = true;
            chReqNumAndLet.Location = new Point(18, 72);
            chReqNumAndLet.Name = "chReqNumAndLet";
            chReqNumAndLet.Size = new Size(165, 19);
            chReqNumAndLet.TabIndex = 3;
            chReqNumAndLet.Text = "Requiere números y letras.";
            chReqNumAndLet.UseVisualStyleBackColor = true;
            // 
            // chMayusAndMin
            // 
            chMayusAndMin.AutoSize = true;
            chMayusAndMin.Location = new Point(18, 47);
            chMayusAndMin.Name = "chMayusAndMin";
            chMayusAndMin.Size = new Size(222, 19);
            chMayusAndMin.TabIndex = 2;
            chMayusAndMin.Text = "Requiere mayúsculas y minínusculas.";
            chMayusAndMin.UseVisualStyleBackColor = true;
            // 
            // chMinCharacters
            // 
            chMinCharacters.AutoSize = true;
            chMinCharacters.Checked = true;
            chMinCharacters.CheckState = CheckState.Checked;
            chMinCharacters.Location = new Point(18, 22);
            chMinCharacters.Name = "chMinCharacters";
            chMinCharacters.Size = new Size(359, 19);
            chMinCharacters.TabIndex = 1;
            chMinCharacters.Text = "Verifica si hay un minímo largo para las contraseñas de usuario.";
            chMinCharacters.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(408, 314);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Location = new Point(327, 314);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmConfiguration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(507, 346);
            Controls.Add(btnCancelar);
            Controls.Add(btnSave);
            Controls.Add(gbConfig);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmConfiguration";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Configuración";
            FormClosing += frmConfiguration_FormClosing;
            Load += frmConfiguration_Load;
            gbConfig.ResumeLayout(false);
            gbConfig.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbConfig;
        private Button btnSave;
        private Button btnCancelar;
        private CheckBox chAllowOldPass;
        private CheckBox chReqConfSecQuestions;
        private CheckBox chReq2FA;
        private CheckBox chReqAtLeast1Sp;
        private CheckBox chReqNumAndLet;
        private CheckBox chMayusAndMin;
        private CheckBox chMinCharacters;
        private Label lblAttemptsToLogin;
        private MaskedTextBox mkRestartBefore;
        private CheckBox chAllowAutoUnlock;
        private Label lblRestartAfter;
        private MaskedTextBox mkQuantityBeforeBlock;
    }
}