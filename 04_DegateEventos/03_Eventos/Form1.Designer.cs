namespace _03_Eventos;

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
            this.btnVideoEncode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVideoEncode
            // 
            this.btnVideoEncode.Location = new System.Drawing.Point(263, 219);
            this.btnVideoEncode.Name = "btnVideoEncode";
            this.btnVideoEncode.Size = new System.Drawing.Size(257, 98);
            this.btnVideoEncode.TabIndex = 0;
            this.btnVideoEncode.Text = "Video Encode";
            this.btnVideoEncode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVideoEncode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

    }

    #endregion

    private Button btnVideoEncode;
}
