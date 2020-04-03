﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_Module9_TP06.Entities
{
    public class Tweet
    {
        private User user;
        private String data;
        private DateTime createdAt;

        public User User
        {
            get { return user; }
            set { user = value; }
        }
        public String Data
        {
            get { return data; }
            set { data = value; }
        }
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }
    }
}
