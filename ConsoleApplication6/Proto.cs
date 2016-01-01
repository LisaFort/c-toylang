using ConsoleApplication6.src.domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication6
{
    public partial class Proto : Form
    {
        TableLayoutPanel grp1;
        GroupBox fpn1;
        Label lbl1;
        Label lbl2;
        Label lbl3;
        Button bt1;
        Button bt2;
        Button bt3;
        Button bt4;
        Button bt5;
        Button bt6;
        Button bt7;
        Button b1;
        RadioButton r1;
        RadioButton r2;
        RadioButton r3;
        RadioButton r4;
        RadioButton r5;
        RadioButton r6;
        RadioButton r7;
        RadioButton r8;
        RadioButton r9;
        RadioButton r10;
        IStmt stm;


        public Proto()
        {
            Text = "Toy Language Menu";
            Size = new Size(500, 500);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Image myimage = new Bitmap(@"D:\forapp\1.jpg");
            this.BackgroundImage = myimage;
            mainmenu();

        }

        public void mainmenu()
        {
            grp1 = new TableLayoutPanel();
            grp1.Parent = this;
            grp1.Location = new Point(150, 80);
            grp1.AutoSize = true;
            grp1.BackColor = Color.FromArgb(210, 121, 84);
            grp1.Text = "Main Menu";
            grp1.Padding = new Padding(10);
            grp1.BorderStyle = BorderStyle.FixedSingle;

            lbl2 = new Label();
            lbl2.Parent = grp1;
            lbl2.Text = "Main Menu";
            lbl2.Font = new Font("Comic Sans", 12);
            lbl2.AutoSize = false;
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            lbl2.Dock = DockStyle.Fill;
            grp1.Controls.Add(lbl2);

            lbl3 = new Label();
            lbl3.Parent = grp1;
            lbl3.Font = new Font("Comic Sans", 7);
            grp1.Controls.Add(lbl3);

            bt4 = new Button();
            bt4.Text = "Add new program";
            bt4.Parent = grp1;
            grp1.Controls.Add(bt4);
            bt4.Dock = DockStyle.Top;
            bt4.Click += new EventHandler(OnClickAdd1);

            bt3 = new Button();
            bt3.Text = "One Step";
            bt3.Parent = grp1;
            grp1.Controls.Add(bt3);
            bt3.Dock = DockStyle.Top;

            bt2 = new Button();
            bt2.Text = "All steps";
            bt2.Parent = grp1;
            grp1.Controls.Add(bt2);
            bt2.Dock = DockStyle.Top;

            bt1 = new Button();
            bt1.Text = "Print State";
            bt1.Parent = grp1;
            grp1.Controls.Add(bt1);
            bt1.Dock = DockStyle.Top;

            bt4 = new Button();
            bt4.Text = "Write to file";
            bt4.Parent = grp1;
            grp1.Controls.Add(bt4);
            bt4.Dock = DockStyle.Top;

            bt6 = new Button();
            bt6.Text = "Serialize";
            bt6.Parent = grp1;
            grp1.Controls.Add(bt6);
            bt6.Dock = DockStyle.Top;


            bt5 = new Button();
            bt5.Text = "Deserialize";
            bt5.Parent = grp1;
            grp1.Controls.Add(bt5);
            bt5.Dock = DockStyle.Top;
        }

        void StmtMenu()
        {
            fpn1 = new GroupBox();
            fpn1.Text = "Choose the statement type: ";
            fpn1.Parent = this;
            fpn1.Location = new Point(150, 80);
            fpn1.AutoSize = true;
            fpn1.BackColor = Color.Transparent;
            b1 = new Button();
            r1 = new RadioButton();
            r1.Text = "Assign";
            r1.Dock = DockStyle.Bottom;
            r1.Click += new EventHandler(AddAssign);
            r2 = new RadioButton();
            r2.Text = "Compound";
            r2.Dock = DockStyle.Bottom;
            r2.Click += new EventHandler(Somef);
            r3 = new RadioButton();
            r3.Text = "Fork";
            r3.Dock = DockStyle.Bottom;
            r3.Click += new EventHandler(Somef);
            r4 = new RadioButton();
            r4.Text = "If";
            r4.Dock = DockStyle.Bottom;
            r4.Click += new EventHandler(Somef);
            r5 = new RadioButton();
            r5.Text = "If-Then";
            r5.Dock = DockStyle.Bottom;
            r5.Click += new EventHandler(Somef);
            r6 = new RadioButton();
            r6.Text = "New Heap";
            r6.Dock = DockStyle.Bottom;
            r6.Click += new EventHandler(Somef);
            r7 = new RadioButton();
            r7.Text = "Print";
            r7.Dock = DockStyle.Bottom;
            r7.Click += new EventHandler(Somef);
            r8 = new RadioButton();
            r8.Text = "Switch";
            r8.Dock = DockStyle.Bottom;
            r8.Click += new EventHandler(Somef);
            r9 = new RadioButton();
            r9.Text = "While";
            r9.Dock = DockStyle.Bottom;
            r9.Click += new EventHandler(Somef);
            r10 = new RadioButton();
            r10.Text = "Write Heap";
            r10.Dock = DockStyle.Bottom;
            r10.Click += new EventHandler(Somef);
            fpn1.Controls.Add(r1);
            fpn1.Controls.Add(r2);
            fpn1.Controls.Add(r3);
            fpn1.Controls.Add(r4);
            fpn1.Controls.Add(r5);
            fpn1.Controls.Add(r6);
            fpn1.Controls.Add(r7);
            fpn1.Controls.Add(r8);
            fpn1.Controls.Add(r9);
            fpn1.Controls.Add(r10);
            fpn1.Padding = new Padding(10);
            grp1.Parent = null;

        }

        void Somef(object sender, EventArgs e)
        {

        }

        void AddAssign(object sender, EventArgs e)
        {
            fpn1.Parent = null;
            TextBox tb = new TextBox();
        }


        void OnClickAdd1(object sender, EventArgs e)
        {
            StmtMenu();
            //IStmt stm = AddStmt(i);
        }


        static public void gMain()
        {
            Application.Run(new Proto());
        }
    }
}
