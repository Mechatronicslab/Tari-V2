﻿using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace design_dance
{
    public partial class f_signin : Form
    {
        static string developmentUri = "mongodb://localhost:27017";
        static string ProductionUri = "mongodb://maria:maria123@167.205.7.226:27017";
        public static IMongoDatabase db;
        public static IMongoClient client;
        public f_signin()
        {
            InitializeComponent();
            //Connect();
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }

        private void b_signin_Click(object sender, EventArgs e)
        {
            string username = mUsername.TextName;
            string password = mPassword.TextName;
            //signIn(username, password);
            if(username == "admin" & password == "admin")
            {
                f_mainAdmin admin = new f_mainAdmin();
                admin.Show();
                this.Visible = false;
            }else if(username == "user" & password == "user"){
                f_mainUser user = new f_mainUser();
                user.Show();
                this.Visible = false;
            }
        }

        public static void Connect()
        {
            client = new MongoClient(developmentUri);
            db = client.GetDatabase("Tari");
            bool isMongoLive = db.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(1000);
            if (isMongoLive)
            {
                // connected
                Console.WriteLine("Koneksi Berhasil");
            }
            else
            {
                // couldn't connect
                MessageBox.Show("Koneksi Bermasalah atau Server Mengalami Gangguan !! ");
                Environment.Exit(0);
            }
        }

        public void signIn(string username, string password)
        {
            IMongoCollection<User> collection = db.GetCollection<User>("users");
            var builder = Builders<User>.Filter;
            var filt = builder.Eq("username", username) & builder.Eq("password", password);
            var ress = collection.Find(filt).FirstOrDefaultAsync().Result;

            if (ress != null)
            {
                f_mainAdmin frm = new f_mainAdmin();
                frm.Show();
                this.Visible = false;
                //MessageBox.Show("Login Sukses !!");
            }
            else
            {
                MessageBox.Show("Username atau Password Salah !!");
            }
        }     
    }
}
