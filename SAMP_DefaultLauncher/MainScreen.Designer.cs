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
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.user_nickname = new System.Windows.Forms.TextBox();
            this.btnSite = new System.Windows.Forms.Button();
            this.select_game = new System.Windows.Forms.GroupBox();
            this.select_game_crmp_037 = new System.Windows.Forms.RadioButton();
            this.select_game_crmp_03e = new System.Windows.Forms.RadioButton();
            this.select_game_samp = new System.Windows.Forms.RadioButton();
            this.label_error_message = new System.Windows.Forms.Label();
            this.button_select_crmp_path = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.server_ip = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnCRPath = new System.Windows.Forms.ToolStripMenuItem();
            this.select_game.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlayGame
            // 
            resources.ApplyResources(this.btnPlayGame, "btnPlayGame");
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // user_nickname
            // 
            resources.ApplyResources(this.user_nickname, "user_nickname");
            this.user_nickname.Name = "user_nickname";
            // 
            // btnSite
            // 
            this.btnSite.CausesValidation = false;
            resources.ApplyResources(this.btnSite, "btnSite");
            this.btnSite.Name = "btnSite";
            this.btnSite.UseVisualStyleBackColor = true;
            this.btnSite.Click += new System.EventHandler(this.btnSite_Click);
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
            // select_game_crmp_037
            // 
            resources.ApplyResources(this.select_game_crmp_037, "select_game_crmp_037");
            this.select_game_crmp_037.Name = "select_game_crmp_037";
            this.select_game_crmp_037.TabStop = true;
            this.select_game_crmp_037.UseVisualStyleBackColor = true;
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
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // server_ip
            // 
            resources.ApplyResources(this.server_ip, "server_ip");
            this.server_ip.Name = "server_ip";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCRPath});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // btnCRPath
            // 
            this.btnCRPath.Name = "btnCRPath";
            resources.ApplyResources(this.btnCRPath, "btnCRPath");
            this.btnCRPath.Click += new System.EventHandler(this.btnCRPath_Click);
            // 
            // MainScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.server_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_select_crmp_path);
            this.Controls.Add(this.label_error_message);
            this.Controls.Add(this.select_game);
            this.Controls.Add(this.user_nickname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSite);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainScreen";
            this.select_game.ResumeLayout(false);
            this.select_game.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user_nickname;
        private System.Windows.Forms.Button btnSite;
        private System.Windows.Forms.GroupBox select_game;
        private System.Windows.Forms.RadioButton select_game_crmp_03e;
        private System.Windows.Forms.RadioButton select_game_samp;
        private System.Windows.Forms.Label label_error_message;
        private System.Windows.Forms.Button button_select_crmp_path;
        private System.Windows.Forms.RadioButton select_game_crmp_037;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox server_ip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnCRPath;
    }
}

