using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_Chu_de_2.Model
{
    public class DSGiangVien
    {
        private List<GiangVien> _giangVienList;
        public List<GiangVien> GiangVienList
        {
            get { return _giangVienList; }
        }

        public DSGiangVien()
        {
            _giangVienList = new List<GiangVien>();
        }

        public void ThemGiangVien(GiangVien giangVien)
        {
            _giangVienList.Add(giangVien);
        }

        public void XoaGiangVien(GiangVien giangVien)
        {
            _giangVienList.Remove(giangVien);
        }

        public void SapXep(Comparison<GiangVien> comparison)
        {
            _giangVienList.Sort(comparison);
        }


        public GiangVien this[int index]
        {
            get { return _giangVienList[index]; }
        }
        public int Count
        {
            get { return _giangVienList.Count; }
        }
    }
}
