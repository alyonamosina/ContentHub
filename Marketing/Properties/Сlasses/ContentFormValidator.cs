using System;
using System.Collections.Generic;
using System.Text;

namespace Marketing.Properties.Сlasses
{
    public class ContentFormValidator
    {
        public bool Validate(
            string title,
            string description,
            string viewsText,
            string author,
            bool isAuthorSelected,
            string type,
            bool isTypeSelected,
            string platform,
            bool isPlatformSelected)
        {
            return !(
                string.IsNullOrWhiteSpace(title) ||
                string.IsNullOrWhiteSpace(description) ||
                string.IsNullOrWhiteSpace(viewsText) ||
                (!isAuthorSelected && string.IsNullOrWhiteSpace(author)) ||
                (!isTypeSelected && string.IsNullOrWhiteSpace(type)) ||
                (!isPlatformSelected && string.IsNullOrWhiteSpace(platform))
            );
        }
    }
}
