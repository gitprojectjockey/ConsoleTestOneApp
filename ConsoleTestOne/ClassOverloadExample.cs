using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestOne
{
    public class ClassOverloadExample
    {
        public int OrderNumber { get; } = 5619854;
        public int WarehouseId { get; } = 99;
        public int WarehousePalletId { get; } = 345;


        public override string ToString()
        {
            return $"This is class {nameof(ClassOverloadExample)}";
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 17;
                // Suitable nullity checks etc, of course :)
                hash = hash * 23 + OrderNumber.GetHashCode();
                hash = hash * 23 + WarehouseId.GetHashCode();
                hash = hash * 23 + WarehousePalletId.GetHashCode();
                return hash;
            }
        }
    }
}
