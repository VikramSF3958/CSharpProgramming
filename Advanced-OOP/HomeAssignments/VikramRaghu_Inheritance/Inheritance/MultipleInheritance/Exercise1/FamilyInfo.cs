

namespace Exercise1
{
    public interface IFamilyInfo : IShowData
    {
        string FatherName { get; set; }

        string MotherName { get; set; }

        int SiblingsCount { get; set; }

        void ShowInfo();

    }
}