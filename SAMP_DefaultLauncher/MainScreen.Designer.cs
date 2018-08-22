namespace SAMP_DefaultLauncher
{
    partial class MainScreen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.button_to_game = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.input_user_nickname = new System.Windows.Forms.TextBox();
            this.button_to_site = new System.Windows.Forms.Button();
            this.select_game = new System.Windows.Forms.GroupBox();
            this.select_game_crmp_03e = new System.Windows.Forms.RadioButton();
            this.select_game_samp = new System.Windows.Forms.RadioButton();
            this.label_error_message = new System.Windows.Forms.Label();
            this.button_select_crmp_path = new System.Windows.Forms.Button();
            this.select_game_crmp_037 = new System.Windows.Forms.RadioButton();
            this.select_game.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_to_game
            // 
            resources.ApplyResources(this.button_to_game, "button_to_game");
            this.button_to_game.Name = "button_to_game";
            this.button_to_game.UseVisualStyleBackColor = true;
            this.button_to_game.Click += new System.EventHandler(this.button_to_game_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // input_user_nickname
            // 
            resources.ApplyResources(this.input_user_nickname, "input_user_nickname");
            this.input_user_nickname.Name = "input_user_nickname";
            // 
            // button_to_site
            // 
            this.button_to_site.CausesValidation = false;
            resources.ApplyResources(this.button_to_site, "button_to_site");
            this.button_to_site.Name = "button_to_site";
            this.button_to_site.UseVisualStyleBackColor = true;
            this.button_to_site.Click += new System.EventHandler(this.button_to_site_Click);
            // 
            // select_game
            // 
            this.select_game.Controls.Add(this.select_game_crmp_037);
            this.select_game.Controls.Add(this.select_game_crmp_03e);
            this.select_game.Controls.Add(this.select_game_samp);
            resources.ApplyResources(this.select_game, "select_game");
            this.select_game.Name = "select_game";
            this.select_game.TabStop = false;
            // 
            // select_game_crmp_03e
            // 
            resources.ApplyResources(this.select_game_crmp_03e, "select_game_crmp_03e");
            this.select_game_crmp_03e.Name = "select_game_crmp_03e";
            this.select_game_crmp_03e.TabStop = true;
            this.select_game_crmp_03e.UseVisualStyleBackColor = true;
            // 
            // select_game_samp
            // 
            resources.ApplyResources(this.select_game_samp, "select_game_samp");
            this.select_game_samp.Name = "select_game_samp";
            this.select_game_samp.TabStop = true;
            this.select_game_samp.UseVisualStyleBackColor = true;
            // 
            // label_error_message
            // 
            resources.ApplyResources(this.label_error_message, "label_error_message");
            this.label_error_message.Name = "label_error_message";
            // 
            // button_select_crmp_path
            // 
            resources.ApplyResources(this.button_select_crmp_path, "button_select_crmp_path");
            this.button_select_crmp_path.Name = "button_select_crmp_path";
            this.button_select_crmp_path.UseVisualStyleBackColor = true;
            this.button_select_crmp_path.Click += new System.EventHandler(this.button_select_crmp_path_Click);
            // 
            // select_game_crmp_037
            // 
            resources.ApplyResources(this.select_game_crmp_037, "select_game_crmp_037");
            this.select_game_crmp_037.Name = "select_game_crmp_037";
            this.select_game_crmp_037.TabStop = true;
            this.select_game_crmp_037.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_select_crmp_path);
            this.Controls.Add(this.label_error_message);
            this.Controls.Add(this.select_game);
            this.Controls.Add(this.input_user_nickname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_to_site);
            this.Controls.Add(this.button_to_game);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainScreen";
            this.select_game.ResumeLayout(false);
            this.select_game.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_to_game;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_user_nickname;
        private System.Windows.Forms.Button button_to_site;
        private System.Windows.Forms.GroupBox select_game;
        private System.Windows.Forms.RadioButton select_game_crmp_03e;
        private System.Windows.Forms.RadioButton select_game_samp;
        private System.Windows.Forms.Label label_error_message;
        private System.Windows.Forms.Button button_select_crmp_path;
        private System.Windows.Forms.RadioButton select_game_crmp_037;
    }
}

