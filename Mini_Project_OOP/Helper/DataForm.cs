using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Project_OOP.Helper
{
    /// <summary>
    /// ฐานของหน้าจอที่คุยกับฐานข้อมูล: กันกดซ้ำระหว่างรอ, โชว์ cursor รอ,
    /// จับ error แล้วแสดงเป็นข้อความ และมี dialog มาตรฐานที่ทุกหน้าใช้ร่วมกัน
    /// </summary>
    public class DataForm : Form
    {
        /// <summary>true ระหว่างที่กำลังคุยกับฐานข้อมูล</summary>
        protected bool IsBusy { get; private set; }

        /// <summary>หัวข้อของ dialog เตือนข้อมูลไม่ครบ (หน้าไหนอยากใช้คำอื่นให้ override)</summary>
        protected virtual string ValidationTitle => "ข้อมูลไม่ครบ";

        /// <summary>เปิด/ปิดปุ่มตาม IsBusy และตัวที่เลือกอยู่ (ถูกเรียกทุกครั้งที่ IsBusy เปลี่ยน)</summary>
        protected virtual void UpdateButtons() { }

        /// <summary>รันงานฐานข้อมูล คืน true ถ้าสำเร็จ (ถ้าพลาดจะแสดงข้อความ error ให้เอง)</summary>
        protected async Task<bool> TryAsync(Func<Task> action, string errorTitle)
        {
            SetBusy(true);
            try
            {
                await action();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(errorTitle + "\n\n" + ex.Message, "เกิดข้อผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                SetBusy(false);
            }
        }

        /// <summary>เตือนข้อมูลไม่ถูกต้อง แล้วโฟกัสช่องที่ต้องแก้</summary>
        protected void Warn(string message, Control focus)
        {
            MessageBox.Show(message, ValidationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            focus.Focus();
        }

        protected static void ShowSuccess(string message)
        {
            MessageBox.Show(message, "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected static void ShowCannotDelete(string message)
        {
            MessageBox.Show(message, "ลบไม่ได้", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>ถามยืนยันการลบ (ปุ่มเริ่มต้น = ไม่)</summary>
        protected static bool ConfirmDelete(string message)
        {
            var answer = MessageBox.Show(message, "ยืนยันการลบ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            return answer == DialogResult.Yes;
        }

        private void SetBusy(bool busy)
        {
            IsBusy = busy;
            UseWaitCursor = busy;
            UpdateButtons();
        }
    }
}
