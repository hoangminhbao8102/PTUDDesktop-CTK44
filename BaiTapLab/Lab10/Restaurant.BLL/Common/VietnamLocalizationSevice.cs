using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Common
{
    public class VietnamLocalizationSevice : ILocalizationService
    {
        private string _currentLanguageCode;
        private readonly Dictionary<string, Dictionary<string, string>> _translations;

        public VietnamLocalizationSevice()
        {
            // Khởi tạo ngôn ngữ mặc định là tiếng Việt
            _currentLanguageCode = "vi-VN";

            // Dữ liệu dịch cho các ngôn ngữ
            _translations = new Dictionary<string, Dictionary<string, string>>
            {
                { "vi-VN", new Dictionary<string, string>
                    {
                        { "Table", "Bàn" },
                        { "Food", "Món ăn" },
                        { "Amount", "Số tiền" },
                        { "Discount", "Giảm giá" },
                        { "Checkout", "Thanh toán" }
                    }
                },
                { "en-US", new Dictionary<string, string>
                    {
                        { "Table", "Table" },
                        { "Food", "Food" },
                        { "Amount", "Amount" },
                        { "Discount", "Discount" },
                        { "Checkout", "Checkout" }
                    }
                }
            };
        }

        public string FormatCurrency(decimal amount)
        {
            return string.Format(new System.Globalization.CultureInfo(_currentLanguageCode), "{0:C}", amount);
        }

        public string Translate(string key)
        {
            if (_translations.TryGetValue(_currentLanguageCode, out var translations) && translations.ContainsKey(key))
            {
                return translations[key];
            }

            // Nếu không tìm thấy, trả về key gốc
            return key;
        }

        public string GetCurrentLanguage()
        {
            return _currentLanguageCode;
        }

        public void SetLanguage(string languageCode)
        {
            // Kiểm tra xem mã ngôn ngữ có hợp lệ không
            if (!_translations.ContainsKey(languageCode))
            {
                throw new ArgumentException($"Language code '{languageCode}' is not supported.");
            }

            // Cập nhật mã ngôn ngữ hiện tại
            _currentLanguageCode = languageCode;

            // Nếu cần, thực hiện thêm logic tải lại tài nguyên (nếu sử dụng ResourceManager hoặc các tệp ngôn ngữ)
            // Ví dụ: Tải tài nguyên từ ResourceManager
            // ResourceManager = new ResourceManager($"Namespace.Resources.{languageCode}", typeof(VietnamLocalizationService).Assembly);
        }

        public Dictionary<string, string> GetAllTranslations()
        {
            return _translations.TryGetValue(_currentLanguageCode, out var translations) ? translations : new Dictionary<string, string>();
        }
    }
}
