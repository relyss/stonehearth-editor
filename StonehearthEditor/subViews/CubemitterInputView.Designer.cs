namespace StonehearthEditor.subViews
{
   partial class CubemitterInputView
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.nameLabel = new System.Windows.Forms.Label();
         this.nameTextBox = new System.Windows.Forms.TextBox();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.durationLabel = new System.Windows.Forms.Label();
         this.particleLabel = new System.Windows.Forms.Label();
         this.emissionLabel = new System.Windows.Forms.Label();
         this.particleFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
         this.emissionFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
         this.saveButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // nameLabel
         // 
         this.nameLabel.AutoSize = true;
         this.nameLabel.Location = new System.Drawing.Point(19, 13);
         this.nameLabel.Name = "nameLabel";
         this.nameLabel.Size = new System.Drawing.Size(33, 13);
         this.nameLabel.TabIndex = 0;
         this.nameLabel.Text = "name";
         // 
         // nameTextBox
         // 
         this.nameTextBox.Location = new System.Drawing.Point(70, 10);
         this.nameTextBox.Name = "nameTextBox";
         this.nameTextBox.Size = new System.Drawing.Size(92, 20);
         this.nameTextBox.TabIndex = 1;
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(70, 36);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(92, 20);
         this.textBox1.TabIndex = 3;
         // 
         // durationLabel
         // 
         this.durationLabel.AutoSize = true;
         this.durationLabel.Location = new System.Drawing.Point(19, 39);
         this.durationLabel.Name = "durationLabel";
         this.durationLabel.Size = new System.Drawing.Size(45, 13);
         this.durationLabel.TabIndex = 2;
         this.durationLabel.Text = "duration";
         // 
         // particleLabel
         // 
         this.particleLabel.AutoSize = true;
         this.particleLabel.Location = new System.Drawing.Point(19, 69);
         this.particleLabel.Name = "particleLabel";
         this.particleLabel.Size = new System.Drawing.Size(41, 13);
         this.particleLabel.TabIndex = 4;
         this.particleLabel.Text = "particle";
         // 
         // emissionLabel
         // 
         this.emissionLabel.AutoSize = true;
         this.emissionLabel.Location = new System.Drawing.Point(19, 310);
         this.emissionLabel.Name = "emissionLabel";
         this.emissionLabel.Size = new System.Drawing.Size(47, 13);
         this.emissionLabel.TabIndex = 5;
         this.emissionLabel.Text = "emission";
         // 
         // particleFlowLayoutPanel
         // 
         this.particleFlowLayoutPanel.AutoSize = true;
         this.particleFlowLayoutPanel.Location = new System.Drawing.Point(36, 85);
         this.particleFlowLayoutPanel.Name = "particleFlowLayoutPanel";
         this.particleFlowLayoutPanel.Size = new System.Drawing.Size(268, 222);
         this.particleFlowLayoutPanel.TabIndex = 6;
         // 
         // emissionFlowLayoutPanel
         // 
         this.emissionFlowLayoutPanel.AutoSize = true;
         this.emissionFlowLayoutPanel.Location = new System.Drawing.Point(36, 326);
         this.emissionFlowLayoutPanel.Name = "emissionFlowLayoutPanel";
         this.emissionFlowLayoutPanel.Size = new System.Drawing.Size(268, 222);
         this.emissionFlowLayoutPanel.TabIndex = 7;
         // 
         // saveButton
         // 
         this.saveButton.BackColor = System.Drawing.SystemColors.ControlDark;
         this.saveButton.Location = new System.Drawing.Point(247, 10);
         this.saveButton.Name = "saveButton";
         this.saveButton.Size = new System.Drawing.Size(143, 27);
         this.saveButton.TabIndex = 8;
         this.saveButton.Text = "Update Effect";
         this.saveButton.UseVisualStyleBackColor = false;
         // 
         // CubemitterInputView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.saveButton);
         this.Controls.Add(this.emissionFlowLayoutPanel);
         this.Controls.Add(this.particleFlowLayoutPanel);
         this.Controls.Add(this.emissionLabel);
         this.Controls.Add(this.particleLabel);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.durationLabel);
         this.Controls.Add(this.nameTextBox);
         this.Controls.Add(this.nameLabel);
         this.Name = "CubemitterInputView";
         this.Size = new System.Drawing.Size(404, 563);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label nameLabel;
      private System.Windows.Forms.TextBox nameTextBox;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Label durationLabel;
      private System.Windows.Forms.Label particleLabel;
      private System.Windows.Forms.Label emissionLabel;
      private System.Windows.Forms.FlowLayoutPanel particleFlowLayoutPanel;
      private System.Windows.Forms.FlowLayoutPanel emissionFlowLayoutPanel;
      private System.Windows.Forms.Button saveButton;
   }
}
