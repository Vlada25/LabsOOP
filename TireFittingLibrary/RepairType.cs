using System.ComponentModel.DataAnnotations;

namespace TireFittingLibrary
{
    public enum RepairType
    {
        [Display(Name = "Замена шин")]
        TireChange,

        [Display(Name = "Ремонт проколов")]
        PunctureRepair,

        [Display(Name = "Балансировка колёс")]
        WheelBalancing,

        [Display(Name = "Развал-схождение")]
        WheelAlignment
    }
}
