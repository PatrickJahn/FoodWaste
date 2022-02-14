using System.Collections.Generic;
using System.Linq;

namespace FoodWaste.filters {

public class Filter{


    public List<Store> onStoreKind(List<Store> stores, string kind){

        return stores.Where(store => store.brand == kind).ToList();
    }
}

}