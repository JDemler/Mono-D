
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.D.OptionPanels
{
	public partial class ProjectOptions
	{
		private global::Gtk.Notebook notebook1;
		private global::Gtk.VBox vbox6;
		private global::Gtk.Frame frame2;
		private global::Gtk.Alignment GtkAlignment;
		private global::Gtk.Table table5;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label4;
		private global::Gtk.ComboBox cmbCompiler;
		private global::Gtk.CheckButton cbUseDefaultCompiler;
		private global::Gtk.Label label5;
		private global::Gtk.Label label7;
		private global::Gtk.ScrolledWindow scrolledwindow4;
		private global::Gtk.TextView extraCompilerTextView;
		private global::Gtk.Entry text_ObjectsDirectory;
		private global::Gtk.Label GtkLabel12;
		private global::Gtk.Frame frame3;
		private global::Gtk.Alignment GtkAlignment1;
		private global::Gtk.Table table6;
		private global::Gtk.Label label10;
		private global::Gtk.Label label6;
		private global::Gtk.ScrolledWindow scrolledwindow5;
		private global::Gtk.TextView extraLinkerTextView;
		private global::Gtk.Entry text_BinDirectory;
		private global::Gtk.Label GtkLabel13;
		private global::Gtk.Label label1;
		private global::Gtk.Table table2;
		private global::Gtk.Button addLibButton;
		private global::Gtk.Label label8;
		private global::Gtk.Entry libAddEntry;
		private global::Gtk.ScrolledWindow scrolledwindow1;
		private global::Gtk.TreeView libTreeView;
		private global::Gtk.VBox vbox4;
		private global::Gtk.Button browseButton;
		private global::Gtk.Button removeLibButton;
		private global::Gtk.Label label2;
		private global::Gtk.VBox vbox7;
		private global::Gtk.Table table3;
		private global::Gtk.Button includePathAddButton;
		private global::Gtk.Entry includePathEntry;
		private global::Gtk.Label label9;
		private global::Gtk.ScrolledWindow scrolledwindow2;
		private global::Gtk.TreeView includePathTreeView;
		private global::Gtk.VBox vbox5;
		private global::Gtk.Button includePathBrowseButton;
		private global::Gtk.Button includePathRemoveButton;
		private global::Gtk.Label label3;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.D.OptionPanels.ProjectOptions
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.D.OptionPanels.ProjectOptions";
			// Container child MonoDevelop.D.OptionPanels.ProjectOptions.Gtk.Container+ContainerChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 1;
			this.notebook1.ShowBorder = false;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 3;
			// Container child vbox6.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(2));
			this.frame2.LabelYalign = 0F;
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.table5 = new global::Gtk.Table (((uint)(5)), ((uint)(1)), false);
			this.table5.Name = "table5";
			this.table5.RowSpacing = ((uint)(6));
			this.table5.ColumnSpacing = ((uint)(9));
			this.table5.BorderWidth = ((uint)(6));
			// Container child table5.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Compiler");
			this.hbox1.Add (this.label4);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label4]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.cmbCompiler = global::Gtk.ComboBox.NewText ();
			this.cmbCompiler.Name = "cmbCompiler";
			this.hbox1.Add (this.cmbCompiler);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.cmbCompiler]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.cbUseDefaultCompiler = new global::Gtk.CheckButton ();
			this.cbUseDefaultCompiler.CanFocus = true;
			this.cbUseDefaultCompiler.Name = "cbUseDefaultCompiler";
			this.cbUseDefaultCompiler.Label = global::Mono.Unix.Catalog.GetString ("Use Default Compiler");
			this.cbUseDefaultCompiler.Active = true;
			this.cbUseDefaultCompiler.DrawIndicator = true;
			this.cbUseDefaultCompiler.UseUnderline = true;
			this.hbox1.Add (this.cbUseDefaultCompiler);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.cbUseDefaultCompiler]));
			w3.PackType = ((global::Gtk.PackType)(1));
			w3.Position = 2;
			this.table5.Add (this.hbox1);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table5 [this.hbox1]));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Objects directory");
			this.table5.Add (this.label5);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table5 [this.label5]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 0F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Extra Compiler Options");
			this.table5.Add (this.label7);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table5 [this.label7]));
			w6.TopAttach = ((uint)(3));
			w6.BottomAttach = ((uint)(4));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.scrolledwindow4 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow4.CanFocus = true;
			this.scrolledwindow4.Name = "scrolledwindow4";
			this.scrolledwindow4.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow4.Gtk.Container+ContainerChild
			this.extraCompilerTextView = new global::Gtk.TextView ();
			this.extraCompilerTextView.TooltipMarkup = "A newline-separated list of extra options to send to the compiler.\nOne option can" +
				" be in more than one line.\nExample:\n\t`--pkg\n\tcairo`";
			this.extraCompilerTextView.CanFocus = true;
			this.extraCompilerTextView.Name = "extraCompilerTextView";
			this.scrolledwindow4.Add (this.extraCompilerTextView);
			this.table5.Add (this.scrolledwindow4);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table5 [this.scrolledwindow4]));
			w8.TopAttach = ((uint)(4));
			w8.BottomAttach = ((uint)(5));
			// Container child table5.Gtk.Table+TableChild
			this.text_ObjectsDirectory = new global::Gtk.Entry ();
			this.text_ObjectsDirectory.CanFocus = true;
			this.text_ObjectsDirectory.Name = "text_ObjectsDirectory";
			this.text_ObjectsDirectory.IsEditable = true;
			this.text_ObjectsDirectory.InvisibleChar = '●';
			this.table5.Add (this.text_ObjectsDirectory);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table5 [this.text_ObjectsDirectory]));
			w9.TopAttach = ((uint)(2));
			w9.BottomAttach = ((uint)(3));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment.Add (this.table5);
			this.frame2.Add (this.GtkAlignment);
			this.GtkLabel12 = new global::Gtk.Label ();
			this.GtkLabel12.WidthRequest = 101;
			this.GtkLabel12.HeightRequest = 29;
			this.GtkLabel12.Name = "GtkLabel12";
			this.GtkLabel12.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Compiler Options</b>");
			this.GtkLabel12.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel12;
			this.vbox6.Add (this.frame2);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.frame2]));
			w12.Position = 0;
			// Container child vbox6.Gtk.Box+BoxChild
			this.frame3 = new global::Gtk.Frame ();
			this.frame3.Name = "frame3";
			this.frame3.ShadowType = ((global::Gtk.ShadowType)(2));
			this.frame3.LabelYalign = 0F;
			// Container child frame3.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.table6 = new global::Gtk.Table (((uint)(4)), ((uint)(1)), false);
			this.table6.Name = "table6";
			this.table6.RowSpacing = ((uint)(6));
			this.table6.ColumnSpacing = ((uint)(9));
			this.table6.BorderWidth = ((uint)(6));
			// Container child table6.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.Xalign = 0F;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Extra Linker Options");
			this.table6.Add (this.label10);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table6 [this.label10]));
			w13.TopAttach = ((uint)(2));
			w13.BottomAttach = ((uint)(3));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 0F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Output directory");
			this.table6.Add (this.label6);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table6 [this.label6]));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.scrolledwindow5 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow5.CanFocus = true;
			this.scrolledwindow5.Name = "scrolledwindow5";
			this.scrolledwindow5.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow5.Gtk.Container+ContainerChild
			this.extraLinkerTextView = new global::Gtk.TextView ();
			this.extraLinkerTextView.TooltipMarkup = "A newline-separated list of extra options to send to the compiler.\nOne option can" +
				" be in more than one line.\nExample:\n\t`--pkg\n\tcairo`";
			this.extraLinkerTextView.CanFocus = true;
			this.extraLinkerTextView.Name = "extraLinkerTextView";
			this.scrolledwindow5.Add (this.extraLinkerTextView);
			this.table6.Add (this.scrolledwindow5);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table6 [this.scrolledwindow5]));
			w16.TopAttach = ((uint)(3));
			w16.BottomAttach = ((uint)(4));
			// Container child table6.Gtk.Table+TableChild
			this.text_BinDirectory = new global::Gtk.Entry ();
			this.text_BinDirectory.CanFocus = true;
			this.text_BinDirectory.Name = "text_BinDirectory";
			this.text_BinDirectory.IsEditable = true;
			this.text_BinDirectory.InvisibleChar = '●';
			this.table6.Add (this.text_BinDirectory);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table6 [this.text_BinDirectory]));
			w17.TopAttach = ((uint)(1));
			w17.BottomAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment1.Add (this.table6);
			this.frame3.Add (this.GtkAlignment1);
			this.GtkLabel13 = new global::Gtk.Label ();
			this.GtkLabel13.WidthRequest = 86;
			this.GtkLabel13.HeightRequest = 29;
			this.GtkLabel13.Name = "GtkLabel13";
			this.GtkLabel13.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Linker Options</b>");
			this.GtkLabel13.UseMarkup = true;
			this.frame3.LabelWidget = this.GtkLabel13;
			this.vbox6.Add (this.frame3);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.frame3]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			this.notebook1.Add (this.vbox6);
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Build");
			this.notebook1.SetTabLabel (this.vbox6, this.label1);
			this.label1.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.table2 = new global::Gtk.Table (((uint)(2)), ((uint)(3)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(10));
			this.table2.ColumnSpacing = ((uint)(10));
			this.table2.BorderWidth = ((uint)(3));
			// Container child table2.Gtk.Table+TableChild
			this.addLibButton = new global::Gtk.Button ();
			this.addLibButton.Sensitive = false;
			this.addLibButton.CanFocus = true;
			this.addLibButton.Name = "addLibButton";
			this.addLibButton.UseUnderline = true;
			this.addLibButton.Label = global::Mono.Unix.Catalog.GetString ("Add");
			this.table2.Add (this.addLibButton);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table2 [this.addLibButton]));
			w22.LeftAttach = ((uint)(2));
			w22.RightAttach = ((uint)(3));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Library:");
			this.table2.Add (this.label8);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table2 [this.label8]));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.libAddEntry = new global::Gtk.Entry ();
			this.libAddEntry.CanFocus = true;
			this.libAddEntry.Name = "libAddEntry";
			this.libAddEntry.IsEditable = true;
			this.libAddEntry.InvisibleChar = '?';
			this.table2.Add (this.libAddEntry);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table2 [this.libAddEntry]));
			w24.LeftAttach = ((uint)(1));
			w24.RightAttach = ((uint)(2));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			this.libTreeView = new global::Gtk.TreeView ();
			this.libTreeView.CanFocus = true;
			this.libTreeView.Name = "libTreeView";
			this.scrolledwindow1.Add (this.libTreeView);
			this.table2.Add (this.scrolledwindow1);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table2 [this.scrolledwindow1]));
			w26.TopAttach = ((uint)(1));
			w26.BottomAttach = ((uint)(2));
			w26.LeftAttach = ((uint)(1));
			w26.RightAttach = ((uint)(2));
			// Container child table2.Gtk.Table+TableChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.browseButton = new global::Gtk.Button ();
			this.browseButton.CanFocus = true;
			this.browseButton.Name = "browseButton";
			this.browseButton.UseUnderline = true;
			this.browseButton.Label = global::Mono.Unix.Catalog.GetString ("Browse...");
			this.vbox4.Add (this.browseButton);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.browseButton]));
			w27.Position = 0;
			w27.Expand = false;
			w27.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.removeLibButton = new global::Gtk.Button ();
			this.removeLibButton.Sensitive = false;
			this.removeLibButton.CanFocus = true;
			this.removeLibButton.Name = "removeLibButton";
			this.removeLibButton.UseUnderline = true;
			this.removeLibButton.Label = global::Mono.Unix.Catalog.GetString ("Remove");
			this.vbox4.Add (this.removeLibButton);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.removeLibButton]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			this.table2.Add (this.vbox4);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table2 [this.vbox4]));
			w29.TopAttach = ((uint)(1));
			w29.BottomAttach = ((uint)(2));
			w29.LeftAttach = ((uint)(2));
			w29.RightAttach = ((uint)(3));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			this.notebook1.Add (this.table2);
			global::Gtk.Notebook.NotebookChild w30 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.table2]));
			w30.Position = 1;
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Libraries");
			this.notebook1.SetTabLabel (this.table2, this.label2);
			this.label2.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox7 = new global::Gtk.VBox ();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			this.vbox7.BorderWidth = ((uint)(3));
			// Container child vbox7.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table (((uint)(2)), ((uint)(3)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(10));
			this.table3.ColumnSpacing = ((uint)(10));
			// Container child table3.Gtk.Table+TableChild
			this.includePathAddButton = new global::Gtk.Button ();
			this.includePathAddButton.Sensitive = false;
			this.includePathAddButton.CanFocus = true;
			this.includePathAddButton.Name = "includePathAddButton";
			this.includePathAddButton.UseUnderline = true;
			this.includePathAddButton.Label = global::Mono.Unix.Catalog.GetString ("Add");
			this.table3.Add (this.includePathAddButton);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table3 [this.includePathAddButton]));
			w31.LeftAttach = ((uint)(2));
			w31.RightAttach = ((uint)(3));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.includePathEntry = new global::Gtk.Entry ();
			this.includePathEntry.CanFocus = true;
			this.includePathEntry.Name = "includePathEntry";
			this.includePathEntry.IsEditable = true;
			this.includePathEntry.InvisibleChar = '?';
			this.table3.Add (this.includePathEntry);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table3 [this.includePathEntry]));
			w32.LeftAttach = ((uint)(1));
			w32.RightAttach = ((uint)(2));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Include Paths:");
			this.table3.Add (this.label9);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table3 [this.label9]));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.scrolledwindow2 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow2.CanFocus = true;
			this.scrolledwindow2.Name = "scrolledwindow2";
			this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow2.Gtk.Container+ContainerChild
			this.includePathTreeView = new global::Gtk.TreeView ();
			this.includePathTreeView.CanFocus = true;
			this.includePathTreeView.Name = "includePathTreeView";
			this.scrolledwindow2.Add (this.includePathTreeView);
			this.table3.Add (this.scrolledwindow2);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table3 [this.scrolledwindow2]));
			w35.TopAttach = ((uint)(1));
			w35.BottomAttach = ((uint)(2));
			w35.LeftAttach = ((uint)(1));
			w35.RightAttach = ((uint)(2));
			// Container child table3.Gtk.Table+TableChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.includePathBrowseButton = new global::Gtk.Button ();
			this.includePathBrowseButton.CanFocus = true;
			this.includePathBrowseButton.Name = "includePathBrowseButton";
			this.includePathBrowseButton.UseUnderline = true;
			this.includePathBrowseButton.Label = global::Mono.Unix.Catalog.GetString ("Browse...");
			this.vbox5.Add (this.includePathBrowseButton);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.includePathBrowseButton]));
			w36.Position = 0;
			w36.Expand = false;
			w36.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.includePathRemoveButton = new global::Gtk.Button ();
			this.includePathRemoveButton.Sensitive = false;
			this.includePathRemoveButton.CanFocus = true;
			this.includePathRemoveButton.Name = "includePathRemoveButton";
			this.includePathRemoveButton.UseUnderline = true;
			this.includePathRemoveButton.Label = global::Mono.Unix.Catalog.GetString ("Remove");
			this.vbox5.Add (this.includePathRemoveButton);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.includePathRemoveButton]));
			w37.Position = 1;
			w37.Expand = false;
			w37.Fill = false;
			this.table3.Add (this.vbox5);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table3 [this.vbox5]));
			w38.TopAttach = ((uint)(1));
			w38.BottomAttach = ((uint)(2));
			w38.LeftAttach = ((uint)(2));
			w38.RightAttach = ((uint)(3));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox7.Add (this.table3);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.table3]));
			w39.Position = 0;
			this.notebook1.Add (this.vbox7);
			global::Gtk.Notebook.NotebookChild w40 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vbox7]));
			w40.Position = 2;
			// Notebook tab
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Includes");
			this.notebook1.SetTabLabel (this.vbox7, this.label3);
			this.label3.ShowAll ();
			this.Add (this.notebook1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.cbUseDefaultCompiler.Clicked += new global::System.EventHandler (this.cbUseDefaultCompiler_Clicked);
			this.removeLibButton.Clicked += new global::System.EventHandler (this.OnRemoveLibButtonClicked);
			this.removeLibButton.Clicked += new global::System.EventHandler (this.OnLibRemoved);
			this.libTreeView.CursorChanged += new global::System.EventHandler (this.OnLibTreeViewCursorChanged);
			this.libAddEntry.Changed += new global::System.EventHandler (this.OnLibAddEntryChanged);
			this.libAddEntry.Activated += new global::System.EventHandler (this.OnLibAddEntryActivated);
			this.addLibButton.Clicked += new global::System.EventHandler (this.OnLibAdded);
			this.includePathBrowseButton.Clicked += new global::System.EventHandler (this.OnIncludePathBrowseButtonClick);
			this.includePathRemoveButton.Clicked += new global::System.EventHandler (this.OnIncludePathRemoveButtonClicked);
			this.includePathRemoveButton.Clicked += new global::System.EventHandler (this.OnIncludePathRemoved);
			this.includePathTreeView.CursorChanged += new global::System.EventHandler (this.OnIncludePathTreeViewCursorChanged);
			this.includePathEntry.Changed += new global::System.EventHandler (this.OnIncludePathEntryChanged);
			this.includePathEntry.Activated += new global::System.EventHandler (this.OnIncludePathEntryActivated);
			this.includePathAddButton.Clicked += new global::System.EventHandler (this.OnIncludePathAdded);
		}
	}
}
