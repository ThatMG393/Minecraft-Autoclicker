namespace Blatant_Autoclicker
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.title = new System.Windows.Forms.Label();
            this.lcpsslider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.lsliderval = new System.Windows.Forms.Label();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.info1 = new System.Windows.Forms.Label();
            this.info2 = new System.Windows.Forms.Label();
            this.rcpsslider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.rsliderval = new System.Windows.Forms.Label();
            this.Autoclicker = new System.Windows.Forms.Timer(this.components);
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.randomTB = new Bunifu.UI.WinForms.BunifuHSlider();
            this.toggleBut = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.lcpsrand = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.info3 = new System.Windows.Forms.Label();
            this.Alert = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.DodgerBlue;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(51, 26);
            this.title.TabIndex = 0;
            this.title.Text = "title";
            // 
            // lcpsslider
            // 
            this.lcpsslider.AllowCursorChanges = true;
            this.lcpsslider.AllowHomeEndKeysDetection = false;
            this.lcpsslider.AllowIncrementalClickMoves = true;
            this.lcpsslider.AllowMouseDownEffects = false;
            this.lcpsslider.AllowMouseHoverEffects = false;
            this.lcpsslider.AllowScrollingAnimations = true;
            this.lcpsslider.AllowScrollKeysDetection = true;
            this.lcpsslider.AllowScrollOptionsMenu = true;
            this.lcpsslider.AllowShrinkingOnFocusLost = false;
            this.lcpsslider.BackColor = System.Drawing.Color.Transparent;
            this.lcpsslider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lcpsslider.BackgroundImage")));
            this.lcpsslider.BindingContainer = null;
            this.lcpsslider.BorderRadius = 2;
            this.lcpsslider.BorderThickness = 1;
            this.lcpsslider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lcpsslider.DrawThickBorder = false;
            this.lcpsslider.DurationBeforeShrink = 2000;
            this.lcpsslider.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.lcpsslider.LargeChange = 10;
            this.lcpsslider.Location = new System.Drawing.Point(12, 71);
            this.lcpsslider.Maximum = 20;
            this.lcpsslider.Minimum = 6;
            this.lcpsslider.MinimumSize = new System.Drawing.Size(0, 31);
            this.lcpsslider.MinimumThumbLength = 18;
            this.lcpsslider.Name = "lcpsslider";
            this.lcpsslider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.lcpsslider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.lcpsslider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.lcpsslider.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.lcpsslider.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.lcpsslider.ShrinkSizeLimit = 3;
            this.lcpsslider.Size = new System.Drawing.Size(269, 46);
            this.lcpsslider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.lcpsslider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.lcpsslider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.lcpsslider.SmallChange = 1;
            this.lcpsslider.TabIndex = 1;
            this.lcpsslider.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.lcpsslider.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.lcpsslider.ThumbLength = 180;
            this.lcpsslider.ThumbMargin = 1;
            this.lcpsslider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.lcpsslider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.lcpsslider.Value = 10;
            this.lcpsslider.ValueChanged += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs>(this.lsliderchange);
            // 
            // lsliderval
            // 
            this.lsliderval.AutoSize = true;
            this.lsliderval.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsliderval.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lsliderval.Location = new System.Drawing.Point(287, 81);
            this.lsliderval.Name = "lsliderval";
            this.lsliderval.Size = new System.Drawing.Size(99, 26);
            this.lsliderval.TabIndex = 2;
            this.lsliderval.Text = "lsliderval";
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "X";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.Empty;
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeft = null;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRight = null;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleBorderRadius = 0;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(502, 12);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(32, 32);
            this.bunifuButton1.TabIndex = 3;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.closeApp);
            // 
            // info1
            // 
            this.info1.AutoSize = true;
            this.info1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.info1.Location = new System.Drawing.Point(8, 61);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(43, 19);
            this.info1.TabIndex = 4;
            this.info1.Text = "info1";
            // 
            // info2
            // 
            this.info2.AutoSize = true;
            this.info2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.info2.Location = new System.Drawing.Point(8, 182);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(43, 19);
            this.info2.TabIndex = 5;
            this.info2.Text = "info2";
            // 
            // rcpsslider
            // 
            this.rcpsslider.AllowCursorChanges = true;
            this.rcpsslider.AllowHomeEndKeysDetection = false;
            this.rcpsslider.AllowIncrementalClickMoves = true;
            this.rcpsslider.AllowMouseDownEffects = false;
            this.rcpsslider.AllowMouseHoverEffects = false;
            this.rcpsslider.AllowScrollingAnimations = true;
            this.rcpsslider.AllowScrollKeysDetection = true;
            this.rcpsslider.AllowScrollOptionsMenu = true;
            this.rcpsslider.AllowShrinkingOnFocusLost = false;
            this.rcpsslider.BackColor = System.Drawing.Color.Transparent;
            this.rcpsslider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rcpsslider.BackgroundImage")));
            this.rcpsslider.BindingContainer = null;
            this.rcpsslider.BorderRadius = 2;
            this.rcpsslider.BorderThickness = 1;
            this.rcpsslider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rcpsslider.DrawThickBorder = false;
            this.rcpsslider.DurationBeforeShrink = 2000;
            this.rcpsslider.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.rcpsslider.LargeChange = 10;
            this.rcpsslider.Location = new System.Drawing.Point(12, 204);
            this.rcpsslider.Maximum = 20;
            this.rcpsslider.Minimum = 6;
            this.rcpsslider.MinimumSize = new System.Drawing.Size(0, 31);
            this.rcpsslider.MinimumThumbLength = 18;
            this.rcpsslider.Name = "rcpsslider";
            this.rcpsslider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.rcpsslider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.rcpsslider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.rcpsslider.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.rcpsslider.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.rcpsslider.ShrinkSizeLimit = 3;
            this.rcpsslider.Size = new System.Drawing.Size(269, 46);
            this.rcpsslider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.rcpsslider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.rcpsslider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.rcpsslider.SmallChange = 1;
            this.rcpsslider.TabIndex = 6;
            this.rcpsslider.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.rcpsslider.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.rcpsslider.ThumbLength = 180;
            this.rcpsslider.ThumbMargin = 1;
            this.rcpsslider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.rcpsslider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.rcpsslider.Value = 10;
            this.rcpsslider.ValueChanged += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs>(this.rsliderchange);
            // 
            // rsliderval
            // 
            this.rsliderval.AutoSize = true;
            this.rsliderval.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsliderval.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rsliderval.Location = new System.Drawing.Point(287, 213);
            this.rsliderval.Name = "rsliderval";
            this.rsliderval.Size = new System.Drawing.Size(101, 26);
            this.rsliderval.TabIndex = 7;
            this.rsliderval.Text = "rsliderval";
            // 
            // Random
            // 
            this.Random.Enabled = true;
            this.Random.Interval = 150;
            this.Random.Tick += new System.EventHandler(this.randomTick);
            // 
            // randomTB
            // 
            this.randomTB.AllowCursorChanges = true;
            this.randomTB.AllowHomeEndKeysDetection = false;
            this.randomTB.AllowIncrementalClickMoves = true;
            this.randomTB.AllowMouseDownEffects = false;
            this.randomTB.AllowMouseHoverEffects = false;
            this.randomTB.AllowScrollingAnimations = true;
            this.randomTB.AllowScrollKeysDetection = true;
            this.randomTB.AllowScrollOptionsMenu = true;
            this.randomTB.AllowShrinkingOnFocusLost = false;
            this.randomTB.BackColor = System.Drawing.Color.Transparent;
            this.randomTB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("randomTB.BackgroundImage")));
            this.randomTB.BindingContainer = null;
            this.randomTB.BorderRadius = 2;
            this.randomTB.BorderThickness = 1;
            this.randomTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randomTB.DrawThickBorder = false;
            this.randomTB.DurationBeforeShrink = 2000;
            this.randomTB.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.randomTB.LargeChange = 5;
            this.randomTB.Location = new System.Drawing.Point(100, 288);
            this.randomTB.Maximum = 30;
            this.randomTB.Minimum = 0;
            this.randomTB.MinimumSize = new System.Drawing.Size(0, 31);
            this.randomTB.MinimumThumbLength = 18;
            this.randomTB.Name = "randomTB";
            this.randomTB.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.randomTB.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.randomTB.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.randomTB.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.randomTB.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.randomTB.ShrinkSizeLimit = 3;
            this.randomTB.Size = new System.Drawing.Size(269, 46);
            this.randomTB.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.randomTB.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.randomTB.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.randomTB.SmallChange = 1;
            this.randomTB.TabIndex = 12;
            this.randomTB.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.randomTB.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.randomTB.ThumbLength = 43;
            this.randomTB.ThumbMargin = 1;
            this.randomTB.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.randomTB.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.randomTB.Value = 10;
            // 
            // toggleBut
            // 
            this.toggleBut.AllowAnimations = true;
            this.toggleBut.AllowMouseEffects = true;
            this.toggleBut.AllowToggling = false;
            this.toggleBut.AnimationSpeed = 200;
            this.toggleBut.AutoGenerateColors = false;
            this.toggleBut.AutoRoundBorders = false;
            this.toggleBut.AutoSizeLeftIcon = true;
            this.toggleBut.AutoSizeRightIcon = true;
            this.toggleBut.BackColor = System.Drawing.Color.Transparent;
            this.toggleBut.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.toggleBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toggleBut.BackgroundImage")));
            this.toggleBut.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.toggleBut.ButtonText = "Enable";
            this.toggleBut.ButtonTextMarginLeft = 0;
            this.toggleBut.ColorContrastOnClick = 45;
            this.toggleBut.ColorContrastOnHover = 45;
            this.toggleBut.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.toggleBut.CustomizableEdges = borderEdges2;
            this.toggleBut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.toggleBut.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.toggleBut.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.toggleBut.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.toggleBut.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.toggleBut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toggleBut.ForeColor = System.Drawing.Color.White;
            this.toggleBut.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toggleBut.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.toggleBut.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.toggleBut.IconMarginLeft = 11;
            this.toggleBut.IconPadding = 10;
            this.toggleBut.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toggleBut.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.toggleBut.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.toggleBut.IconSize = 25;
            this.toggleBut.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.toggleBut.IdleBorderRadius = 1;
            this.toggleBut.IdleBorderThickness = 1;
            this.toggleBut.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.toggleBut.IdleIconLeftImage = null;
            this.toggleBut.IdleIconRightImage = null;
            this.toggleBut.IndicateFocus = false;
            this.toggleBut.Location = new System.Drawing.Point(238, 12);
            this.toggleBut.Name = "toggleBut";
            this.toggleBut.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.toggleBut.OnDisabledState.BorderRadius = 1;
            this.toggleBut.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.toggleBut.OnDisabledState.BorderThickness = 1;
            this.toggleBut.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.toggleBut.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.toggleBut.OnDisabledState.IconLeftImage = null;
            this.toggleBut.OnDisabledState.IconRightImage = null;
            this.toggleBut.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.toggleBut.onHoverState.BorderRadius = 1;
            this.toggleBut.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.toggleBut.onHoverState.BorderThickness = 1;
            this.toggleBut.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.toggleBut.onHoverState.ForeColor = System.Drawing.Color.White;
            this.toggleBut.onHoverState.IconLeftImage = null;
            this.toggleBut.onHoverState.IconRightImage = null;
            this.toggleBut.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.toggleBut.OnIdleState.BorderRadius = 1;
            this.toggleBut.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.toggleBut.OnIdleState.BorderThickness = 1;
            this.toggleBut.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.toggleBut.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.toggleBut.OnIdleState.IconLeftImage = null;
            this.toggleBut.OnIdleState.IconRightImage = null;
            this.toggleBut.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.toggleBut.OnPressedState.BorderRadius = 1;
            this.toggleBut.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.toggleBut.OnPressedState.BorderThickness = 1;
            this.toggleBut.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.toggleBut.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.toggleBut.OnPressedState.IconLeftImage = null;
            this.toggleBut.OnPressedState.IconRightImage = null;
            this.toggleBut.Size = new System.Drawing.Size(150, 39);
            this.toggleBut.TabIndex = 13;
            this.toggleBut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toggleBut.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.toggleBut.TextMarginLeft = 0;
            this.toggleBut.TextPadding = new System.Windows.Forms.Padding(0);
            this.toggleBut.UseDefaultRadiusAndThickness = true;
            this.toggleBut.Click += new System.EventHandler(this.togButClick);
            // 
            // lcpsrand
            // 
            this.lcpsrand.AllowBindingControlAnimation = true;
            this.lcpsrand.AllowBindingControlColorChanges = false;
            this.lcpsrand.AllowBindingControlLocation = true;
            this.lcpsrand.AllowCheckBoxAnimation = false;
            this.lcpsrand.AllowCheckmarkAnimation = true;
            this.lcpsrand.AllowOnHoverStates = true;
            this.lcpsrand.AutoCheck = true;
            this.lcpsrand.BackColor = System.Drawing.Color.Transparent;
            this.lcpsrand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lcpsrand.BackgroundImage")));
            this.lcpsrand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lcpsrand.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.lcpsrand.BorderRadius = 12;
            this.lcpsrand.Checked = true;
            this.lcpsrand.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.lcpsrand.Cursor = System.Windows.Forms.Cursors.Default;
            this.lcpsrand.CustomCheckmarkImage = null;
            this.lcpsrand.Location = new System.Drawing.Point(17, 111);
            this.lcpsrand.MinimumSize = new System.Drawing.Size(17, 17);
            this.lcpsrand.Name = "lcpsrand";
            this.lcpsrand.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.lcpsrand.OnCheck.BorderRadius = 12;
            this.lcpsrand.OnCheck.BorderThickness = 2;
            this.lcpsrand.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.lcpsrand.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.lcpsrand.OnCheck.CheckmarkThickness = 2;
            this.lcpsrand.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.lcpsrand.OnDisable.BorderRadius = 12;
            this.lcpsrand.OnDisable.BorderThickness = 2;
            this.lcpsrand.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.lcpsrand.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.lcpsrand.OnDisable.CheckmarkThickness = 2;
            this.lcpsrand.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.lcpsrand.OnHoverChecked.BorderRadius = 12;
            this.lcpsrand.OnHoverChecked.BorderThickness = 2;
            this.lcpsrand.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.lcpsrand.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.lcpsrand.OnHoverChecked.CheckmarkThickness = 2;
            this.lcpsrand.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.lcpsrand.OnHoverUnchecked.BorderRadius = 12;
            this.lcpsrand.OnHoverUnchecked.BorderThickness = 1;
            this.lcpsrand.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.lcpsrand.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.lcpsrand.OnUncheck.BorderRadius = 12;
            this.lcpsrand.OnUncheck.BorderThickness = 1;
            this.lcpsrand.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.lcpsrand.Size = new System.Drawing.Size(21, 21);
            this.lcpsrand.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.lcpsrand.TabIndex = 14;
            this.lcpsrand.ThreeState = false;
            this.lcpsrand.ToolTipText = null;
            this.lcpsrand.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.checkChangeLeft);
            // 
            // info3
            // 
            this.info3.AutoSize = true;
            this.info3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.info3.Location = new System.Drawing.Point(44, 111);
            this.info3.Name = "info3";
            this.info3.Size = new System.Drawing.Size(43, 19);
            this.info3.TabIndex = 15;
            this.info3.Text = "info3";
            // 
            // Alert
            // 
            this.Alert.AllowDragging = false;
            this.Alert.AllowMultipleViews = true;
            this.Alert.ClickToClose = true;
            this.Alert.DoubleClickToClose = true;
            this.Alert.DurationAfterIdle = 3000;
            this.Alert.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.ErrorOptions.ActionBorderRadius = 1;
            this.Alert.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Alert.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Alert.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.Alert.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.Alert.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.Alert.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Alert.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.Alert.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.Alert.ErrorOptions.IconLeftMargin = 12;
            this.Alert.FadeCloseIcon = false;
            this.Alert.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.Alert.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.InformationOptions.ActionBorderRadius = 1;
            this.Alert.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Alert.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Alert.InformationOptions.BackColor = System.Drawing.Color.White;
            this.Alert.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.Alert.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.Alert.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Alert.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.Alert.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.Alert.InformationOptions.IconLeftMargin = 12;
            this.Alert.Margin = 10;
            this.Alert.MaximumSize = new System.Drawing.Size(0, 0);
            this.Alert.MaximumViews = 7;
            this.Alert.MessageRightMargin = 15;
            this.Alert.MinimumSize = new System.Drawing.Size(0, 0);
            this.Alert.ShowBorders = false;
            this.Alert.ShowCloseIcon = false;
            this.Alert.ShowIcon = true;
            this.Alert.ShowShadows = true;
            this.Alert.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.SuccessOptions.ActionBorderRadius = 1;
            this.Alert.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Alert.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Alert.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.Alert.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.Alert.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.Alert.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Alert.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.Alert.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.Alert.SuccessOptions.IconLeftMargin = 12;
            this.Alert.ViewsMargin = 7;
            this.Alert.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.WarningOptions.ActionBorderRadius = 1;
            this.Alert.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Alert.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Alert.WarningOptions.BackColor = System.Drawing.Color.White;
            this.Alert.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.Alert.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.Alert.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Alert.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.Alert.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.Alert.WarningOptions.IconLeftMargin = 12;
            this.Alert.ZoomCloseIcon = true;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(546, 346);
            this.Controls.Add(this.info3);
            this.Controls.Add(this.lcpsrand);
            this.Controls.Add(this.toggleBut);
            this.Controls.Add(this.randomTB);
            this.Controls.Add(this.rsliderval);
            this.Controls.Add(this.rcpsslider);
            this.Controls.Add(this.info2);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.lsliderval);
            this.Controls.Add(this.lcpsslider);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainUI";
            this.Text = "Visual";
            this.Load += new System.EventHandler(this.onLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private Bunifu.UI.WinForms.BunifuHSlider lcpsslider;
        private System.Windows.Forms.Label lsliderval;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.Label info1;
        private System.Windows.Forms.Label info2;
        private Bunifu.UI.WinForms.BunifuHSlider rcpsslider;
        private System.Windows.Forms.Label rsliderval;
        private System.Windows.Forms.Timer Autoclicker;
        protected System.Windows.Forms.Timer Random;
        private Bunifu.UI.WinForms.BunifuHSlider randomTB;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 toggleBut;
        private Bunifu.UI.WinForms.BunifuCheckBox lcpsrand;
        private System.Windows.Forms.Label info3;
        private Bunifu.UI.WinForms.BunifuSnackbar Alert;
    }
}

