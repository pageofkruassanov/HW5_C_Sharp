using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_5_class_exception
{
    internal class Shop
    {
        private string _title;
        private string _adress;
        private string _description;
        private string _phone;
        private string _email;
        public string Title
        {
            get => _title;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception($"Data can't be empty");
                }
                _title = value;
            }
        }
        public string Adress
        {
            get => _adress;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception($"Data can't be empty");
                }
                _adress = value;
            }
        }
        public string Description
        {
            get => _description;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception($"Data can't be empty");
                }
                _description = value;
            }
        }
        public string Phone
        {
            get => _phone;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception($"Data can't be empty");
                }
                _phone = value;
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception($"Data can't be empty");
                }
                _email = value;
            }
        }
        public override string ToString()
        {
            var input = new StringBuilder();
            input.AppendLine($"Title: {_title}");
            input.AppendLine($"Adress: {_adress}");
            input.AppendLine($"Description: {_description}");
            input.AppendLine($"Phone number: {_phone}");
            input.AppendLine($"Email adress: {_email}");
            return input.ToString();
        }
    }
}
