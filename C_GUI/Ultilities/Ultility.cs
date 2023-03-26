using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C_GUI.Ultilities
{
    public class Ultility
    {
        // Loại bỏ tiêng việt
        private static Regex ConvertToUnsign_rg = null;

        public static string GetChuCaiDau(string value)
        {
            return Convert.ToString(value[0]); //= n
        }

        public static string GetMaTuSinh(string value) // Đồng Xuân Huy => Huydx
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return "";
            }
            string temp = value.Trim().ToLower(); // Cắt khoảng cách ở 2 đầu và đưa chữ in hoa về chữ thường
            string[] arrNames = value.Split(' '); // Cắt chuỗi về mảng
            string final = GetVietHoaChuCaiDau(arrNames[arrNames.Length - 1]).Trim(); // Huy
            for (int i = 0; i < arrNames.Length - 1; i++)
            {
                final += GetChuCaiDau(arrNames[i]);
            }
            return ConvertToUnsign(final);
        }

        public static string GetVietHoaChuCaiDau(string value) // đồng
        {
            return Convert.ToString(value[0]).ToUpper() + value.Substring(1) + " "; //= Đồng
        }

        public static string VietHoaChuCaiDau(string value) // đồng XUÂN HUY
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return "";
            }
            string temp = value.Trim().ToLower(); // Cắt khoảng trắng ở 2 đầu và đưa chữ in hoa về chữ thường
            string[] arrNames = temp.Split(' '); // Cắt chuỗi về mảng
            string final = "";
            for (int i = 0; i < arrNames.Length; i++)
            {
                final += GetVietHoaChuCaiDau(arrNames[i]);
            }
            return final;
        }

        private static string ConvertToUnsign(string str)
        {
            string strFormD = str.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < strFormD.Length; i++)
            {
                System.Globalization.UnicodeCategory uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(strFormD[i]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(strFormD[i]);
                }
            }
            sb = sb.Replace('Đ', 'D');
            sb = sb.Replace('đ', 'd');
            return (sb.ToString().Normalize(NormalizationForm.FormD));
        }
    }
}