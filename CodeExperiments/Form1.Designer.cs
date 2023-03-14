namespace CodeExperiments
{
    partial class frmMain
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
            btnCustomAttribute = new Button();
            txtResults = new TextBox();
            btnGenericMath = new Button();
            btnStringInterpolation = new Button();
            btnListPatterns = new Button();
            btnRawStringLiteral = new Button();
            btnAutoDefaultStruct = new Button();
            btnPatternMatching = new Button();
            btnExtendNameOfScope = new Button();
            btnRequiredMembers = new Button();
            btnFileAccessModifier = new Button();
            SuspendLayout();
            // 
            // btnCustomAttribute
            // 
            btnCustomAttribute.Location = new Point(12, 12);
            btnCustomAttribute.Name = "btnCustomAttribute";
            btnCustomAttribute.Size = new Size(154, 29);
            btnCustomAttribute.TabIndex = 0;
            btnCustomAttribute.Text = "CustomAttribute";
            btnCustomAttribute.UseVisualStyleBackColor = true;
            btnCustomAttribute.Click += btnCustomAttribute_Click;
            // 
            // txtResults
            // 
            txtResults.Location = new Point(12, 128);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.Size = new Size(776, 301);
            txtResults.TabIndex = 1;
            // 
            // btnGenericMath
            // 
            btnGenericMath.Location = new Point(12, 47);
            btnGenericMath.Name = "btnGenericMath";
            btnGenericMath.Size = new Size(154, 29);
            btnGenericMath.TabIndex = 2;
            btnGenericMath.Text = "Generic Math";
            btnGenericMath.UseVisualStyleBackColor = true;
            btnGenericMath.Click += btnGenericMath_Click;
            // 
            // btnStringInterpolation
            // 
            btnStringInterpolation.Location = new Point(12, 82);
            btnStringInterpolation.Name = "btnStringInterpolation";
            btnStringInterpolation.Size = new Size(154, 29);
            btnStringInterpolation.TabIndex = 3;
            btnStringInterpolation.Text = "String Interpolation";
            btnStringInterpolation.UseVisualStyleBackColor = true;
            btnStringInterpolation.Click += btnStringInterpolation_Click;
            // 
            // btnListPatterns
            // 
            btnListPatterns.Location = new Point(197, 12);
            btnListPatterns.Name = "btnListPatterns";
            btnListPatterns.Size = new Size(137, 29);
            btnListPatterns.TabIndex = 4;
            btnListPatterns.Text = "ListPatterns";
            btnListPatterns.UseVisualStyleBackColor = true;
            btnListPatterns.Click += btnListPatterns_Click;
            // 
            // btnRawStringLiteral
            // 
            btnRawStringLiteral.Location = new Point(197, 47);
            btnRawStringLiteral.Name = "btnRawStringLiteral";
            btnRawStringLiteral.Size = new Size(137, 29);
            btnRawStringLiteral.TabIndex = 5;
            btnRawStringLiteral.Text = "RawStringLiteral";
            btnRawStringLiteral.UseVisualStyleBackColor = true;
            btnRawStringLiteral.Click += btnRawStringLiteral_Click;
            // 
            // btnAutoDefaultStruct
            // 
            btnAutoDefaultStruct.Location = new Point(197, 82);
            btnAutoDefaultStruct.Name = "btnAutoDefaultStruct";
            btnAutoDefaultStruct.Size = new Size(137, 29);
            btnAutoDefaultStruct.TabIndex = 6;
            btnAutoDefaultStruct.Text = "AutoDefaultStruct";
            btnAutoDefaultStruct.UseVisualStyleBackColor = true;
            btnAutoDefaultStruct.Click += btnAutoDefaultStruct_Click;
            // 
            // btnPatternMatching
            // 
            btnPatternMatching.Location = new Point(365, 12);
            btnPatternMatching.Name = "btnPatternMatching";
            btnPatternMatching.Size = new Size(202, 29);
            btnPatternMatching.TabIndex = 7;
            btnPatternMatching.Text = "MultiplePropertyMatching";
            btnPatternMatching.UseVisualStyleBackColor = true;
            btnPatternMatching.Click += btnPatternMatching_Click;
            // 
            // btnExtendNameOfScope
            // 
            btnExtendNameOfScope.Location = new Point(365, 47);
            btnExtendNameOfScope.Name = "btnExtendNameOfScope";
            btnExtendNameOfScope.Size = new Size(202, 29);
            btnExtendNameOfScope.TabIndex = 8;
            btnExtendNameOfScope.Text = "ExtendNameOfScope";
            btnExtendNameOfScope.UseVisualStyleBackColor = true;
            btnExtendNameOfScope.Click += btnExtendNameOfScope_Click;
            // 
            // btnRequiredMembers
            // 
            btnRequiredMembers.Location = new Point(365, 82);
            btnRequiredMembers.Name = "btnRequiredMembers";
            btnRequiredMembers.Size = new Size(202, 29);
            btnRequiredMembers.TabIndex = 9;
            btnRequiredMembers.Text = "RequiredMembers";
            btnRequiredMembers.UseVisualStyleBackColor = true;
            btnRequiredMembers.Click += btnRequiredMembers_Click;
            // 
            // btnFileAccessModifier
            // 
            btnFileAccessModifier.Location = new Point(596, 12);
            btnFileAccessModifier.Name = "btnFileAccessModifier";
            btnFileAccessModifier.Size = new Size(151, 29);
            btnFileAccessModifier.TabIndex = 10;
            btnFileAccessModifier.Text = "FileAccessModifier";
            btnFileAccessModifier.UseVisualStyleBackColor = true;
            btnFileAccessModifier.Click += btnFileAccessModifier_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFileAccessModifier);
            Controls.Add(btnRequiredMembers);
            Controls.Add(btnExtendNameOfScope);
            Controls.Add(btnPatternMatching);
            Controls.Add(btnAutoDefaultStruct);
            Controls.Add(btnRawStringLiteral);
            Controls.Add(btnListPatterns);
            Controls.Add(btnStringInterpolation);
            Controls.Add(btnGenericMath);
            Controls.Add(txtResults);
            Controls.Add(btnCustomAttribute);
            Name = "frmMain";
            Text = "Experiments";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCustomAttribute;
        private TextBox txtResults;
        private Button btnGenericMath;
        private Button btnStringInterpolation;
        private Button btnListPatterns;
        private Button btnRawStringLiteral;
        private Button btnAutoDefaultStruct;
        private Button btnPatternMatching;
        private Button btnExtendNameOfScope;
        private Button btnRequiredMembers;
        private Button btnFileAccessModifier;
    }
}