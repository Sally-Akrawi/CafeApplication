using DatabaseOperations.Models;

namespace DatabaseOperations.Services
{
    public interface IDataService
    {
        // Milk page functions
        Task<int> CreateMilk(MilkType milk);

        Task<List<MilkType>> ReadMilkTable();

        Task<string> DeleteMilk(int id);
       
        Task<MilkType> UpdateMilk(int x);

        Task<int> UpdateMilk_New(MilkType milkType);
        Task<List<MilkType>> ReadDisableMilkData();
        Task ChangeMilkAvailability(int id);

        Task<MilkType> MilkCustomerDetails(int milk);
      
        Task<List<MilkType>> SortByPrice();

        // Food page functions
        Task<List<FoodMenu>> ReadDisableFoodData();
        Task<int> CreateFood(FoodMenu food);
        Task<List<FoodMenu>> ReadFoodTable();
        Task<FoodMenu> UpdateFood(int id);
        Task<string> DeleteFood(int d);

        Task FoodAvialability(int d);
        Task<FoodMenu> FoodCustomerDetail(int id);

       
        // Tea Page Functions
        Task<int> CreateTea(TeaMenu tea);
        Task<List<TeaMenu>> ReadTea();

        Task<string> DeleteTea(int id);

        Task<TeaMenu> UpdateTea(int id);

        Task<List<TeaMenu>> ReadDisableTea();
        Task<TeaMenu> CustomerTeaDetails(int teaId);
        Task TeaChangeAvialability(int d);

        // Syrup Page Functions

        Task<int> CreateSyrup(SyrupMenu syrup);
        Task<List<SyrupMenu>> ReadSyrup();

        Task<string> DeleteSyrup(int id);

        Task<SyrupMenu> UpdateSyrup(int id);

        Task<List<SyrupMenu>> ReadDisableSyrup();

        Task SyrupChangeAvialability(int d);

        Task<SyrupMenu> CustomerSyrupDetails(int syrupId);

        // Sweetener Page Functions

        Task<int> CreateSweetener(SweetenerMenu syrup);
        Task<List<SweetenerMenu>> ReadSweetener();

        Task<string> DeleteSweetener(int id);

        Task<SweetenerMenu> UpdateSweetener(int id);

        Task<List<SweetenerMenu>> ReadDisableSweetener();

        Task SweetenerChangeAvialability(int d);
        Task<SweetenerMenu> CustomerSweetenerDetails(int sweetenerId);

        // Topping Page Functions

        Task<int> CreateTopping(ToppingMenu top);
        Task<List<ToppingMenu>> ReadTopping();

        Task<string> DeleteTopping(int id);

        Task<ToppingMenu> UpdateTopping(int id);

        Task<List<ToppingMenu>> ReadDisableTopping();

        Task ToppingChangeAvialability(int d);

        Task<ToppingMenu> CustomerToppingDetails(int TopperId);

        // Drinks Page Functions
        Task<int> CreateDrink(DrinkMenu top);
        Task<List<DrinkMenu>> ReadDrink();

        Task<string> DeleteDrink(int id);

        Task<DrinkMenu> UpdateDrink(int id);

        Task<List<DrinkMenu>> ReadDisableDrink();

        Task DrinkChangeAvialability(int id);

        Task<DrinkMenu> CustomerDrinkDetails(int DrinkId);

    }
}
