﻿namespace TP_FINAL
{
    partial class FrmRecuperacionContraseña
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
            this.lblRequisitosRecuperoContraseña = new System.Windows.Forms.Label();
            this.lblEmailRecupero = new System.Windows.Forms.Label();
            this.tbIngreseEmail = new System.Windows.Forms.TextBox();
            this.lblIngreseCodigoEnviadoACorreo = new System.Windows.Forms.Label();
            this.tbCodigoEnviadoEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNuevaContraseña = new System.Windows.Forms.TextBox();
            this.lblConfirmarContraseña = new System.Windows.Forms.Label();
            this.tbConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.btnAceptarRecuperoContraseña = new System.Windows.Forms.Button();
            this.btnObtenerCodigo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRequisitosRecuperoContraseña
            // 
            this.lblRequisitosRecuperoContraseña.AutoSize = true;
            this.lblRequisitosRecuperoContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitosRecuperoContraseña.Location = new System.Drawing.Point(74, 28);
            this.lblRequisitosRecuperoContraseña.Name = "lblRequisitosRecuperoContraseña";
            this.lblRequisitosRecuperoContraseña.Size = new System.Drawing.Size(520, 24);
            this.lblRequisitosRecuperoContraseña.TabIndex = 0;
            this.lblRequisitosRecuperoContraseña.Text = "Por favor complete los campos para recuperar su contraseña";
            // 
            // lblEmailRecupero
            // 
            this.lblEmailRecupero.AutoSize = true;
            this.lblEmailRecupero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailRecupero.Location = new System.Drawing.Point(198, 71);
            this.lblEmailRecupero.Name = "lblEmailRecupero";
            this.lblEmailRecupero.Size = new System.Drawing.Size(123, 18);
            this.lblEmailRecupero.TabIndex = 1;
            this.lblEmailRecupero.Text = "Ingrese su Email";
            // 
            // tbIngreseEmail
            // 
            this.tbIngreseEmail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIngreseEmail.Location = new System.Drawing.Point(202, 94);
            this.tbIngreseEmail.Multiline = true;
            this.tbIngreseEmail.Name = "tbIngreseEmail";
            this.tbIngreseEmail.Size = new System.Drawing.Size(244, 33);
            this.tbIngreseEmail.TabIndex = 2;
            this.tbIngreseEmail.TextChanged += new System.EventHandler(this.tbIngreseEmail_TextChanged);
            // 
            // lblIngreseCodigoEnviadoACorreo
            // 
            this.lblIngreseCodigoEnviadoACorreo.AutoSize = true;
            this.lblIngreseCodigoEnviadoACorreo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseCodigoEnviadoACorreo.Location = new System.Drawing.Point(200, 181);
            this.lblIngreseCodigoEnviadoACorreo.Name = "lblIngreseCodigoEnviadoACorreo";
            this.lblIngreseCodigoEnviadoACorreo.Size = new System.Drawing.Size(246, 18);
            this.lblIngreseCodigoEnviadoACorreo.TabIndex = 3;
            this.lblIngreseCodigoEnviadoACorreo.Text = "Ingrese el codigo enviado al Email";
            // 
            // tbCodigoEnviadoEmail
            // 
            this.tbCodigoEnviadoEmail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoEnviadoEmail.Location = new System.Drawing.Point(203, 202);
            this.tbCodigoEnviadoEmail.Multiline = true;
            this.tbCodigoEnviadoEmail.Name = "tbCodigoEnviadoEmail";
            this.tbCodigoEnviadoEmail.Size = new System.Drawing.Size(243, 34);
            this.tbCodigoEnviadoEmail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese una contraseña nueva";
            // 
            // tbNuevaContraseña
            // 
            this.tbNuevaContraseña.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNuevaContraseña.Location = new System.Drawing.Point(203, 276);
            this.tbNuevaContraseña.Multiline = true;
            this.tbNuevaContraseña.Name = "tbNuevaContraseña";
            this.tbNuevaContraseña.Size = new System.Drawing.Size(243, 31);
            this.tbNuevaContraseña.TabIndex = 6;
            this.tbNuevaContraseña.TextChanged += new System.EventHandler(this.tbNuevaContraseña_TextChanged);
            // 
            // lblConfirmarContraseña
            // 
            this.lblConfirmarContraseña.AutoSize = true;
            this.lblConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContraseña.Location = new System.Drawing.Point(199, 328);
            this.lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            this.lblConfirmarContraseña.Size = new System.Drawing.Size(165, 20);
            this.lblConfirmarContraseña.TabIndex = 7;
            this.lblConfirmarContraseña.Text = "Confirmar Contraseña";
            // 
            // tbConfirmarContraseña
            // 
            this.tbConfirmarContraseña.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmarContraseña.Location = new System.Drawing.Point(203, 351);
            this.tbConfirmarContraseña.Multiline = true;
            this.tbConfirmarContraseña.Name = "tbConfirmarContraseña";
            this.tbConfirmarContraseña.Size = new System.Drawing.Size(243, 26);
            this.tbConfirmarContraseña.TabIndex = 8;
            this.tbConfirmarContraseña.TextChanged += new System.EventHandler(this.tbConfirmarContraseña_TextChanged);
            // 
            // btnAceptarRecuperoContraseña
            // 
            this.btnAceptarRecuperoContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarRecuperoContraseña.Location = new System.Drawing.Point(203, 395);
            this.btnAceptarRecuperoContraseña.Name = "btnAceptarRecuperoContraseña";
            this.btnAceptarRecuperoContraseña.Size = new System.Drawing.Size(243, 40);
            this.btnAceptarRecuperoContraseña.TabIndex = 9;
            this.btnAceptarRecuperoContraseña.Text = "Aceptar";
            this.btnAceptarRecuperoContraseña.UseVisualStyleBackColor = true;
            this.btnAceptarRecuperoContraseña.Click += new System.EventHandler(this.btnAceptarRecuperoContraseña_Click);
            // 
            // btnObtenerCodigo
            // 
            this.btnObtenerCodigo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtenerCodigo.Location = new System.Drawing.Point(203, 133);
            this.btnObtenerCodigo.Name = "btnObtenerCodigo";
            this.btnObtenerCodigo.Size = new System.Drawing.Size(243, 45);
            this.btnObtenerCodigo.TabIndex = 10;
            this.btnObtenerCodigo.Text = "Obtener código de recuperacion";
            this.btnObtenerCodigo.UseVisualStyleBackColor = true;
            this.btnObtenerCodigo.Click += new System.EventHandler(this.btnObtenerCodigo_Click);
            // 
            // FrmRecuperacionContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(649, 518);
            this.Controls.Add(this.btnObtenerCodigo);
            this.Controls.Add(this.btnAceptarRecuperoContraseña);
            this.Controls.Add(this.tbConfirmarContraseña);
            this.Controls.Add(this.lblConfirmarContraseña);
            this.Controls.Add(this.tbNuevaContraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCodigoEnviadoEmail);
            this.Controls.Add(this.lblIngreseCodigoEnviadoACorreo);
            this.Controls.Add(this.tbIngreseEmail);
            this.Controls.Add(this.lblEmailRecupero);
            this.Controls.Add(this.lblRequisitosRecuperoContraseña);
            this.Name = "FrmRecuperacionContraseña";
            this.Text = "FrmRecuperacionContraseña";
            this.Load += new System.EventHandler(this.FrmRecuperacionContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequisitosRecuperoContraseña;
        private System.Windows.Forms.Label lblEmailRecupero;
        private System.Windows.Forms.TextBox tbIngreseEmail;
        private System.Windows.Forms.Label lblIngreseCodigoEnviadoACorreo;
        private System.Windows.Forms.TextBox tbCodigoEnviadoEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNuevaContraseña;
        private System.Windows.Forms.Label lblConfirmarContraseña;
        private System.Windows.Forms.TextBox tbConfirmarContraseña;
        private System.Windows.Forms.Button btnAceptarRecuperoContraseña;
        private System.Windows.Forms.Button btnObtenerCodigo;
    }
}