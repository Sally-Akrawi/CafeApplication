using DatabaseOperations.Data;
using DatabaseOperations.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseOperations.Services
{
    public class DataService : IDataService
    {
        private readonly ApplicationDBContext _db;

        public DataService(ApplicationDBContext db)
        {
            _db = db;
        }
        // Milk page Functions

        /// <summary>
        /// To create a new milk item to the database
        /// set the DisableData to be true in default
        /// </summary>
        /// <param MilkType name="milk"></param>
        /// <returns  int>  </returns>
        public async Task<int> CreateMilk(MilkType milk)
        {
                if (milk != null)
                {
                    if (!_db.MilkTypes.Where(s => s.Name == milk.Name).Any())
                    {
                        if (!milk.DisableData)
                        {
                            milk.DisableData = true;
                        }
						try
						{
                            _db.MilkTypes.Add(milk);
                            await _db.SaveChangesAsync();
                            return milk.Id;
                        }
						catch (Exception)
						{
							throw;
						}                     
                    }
                }
                return 0;           
        }
       

        /// <summary>
        /// To delete item from the database
        /// </summary>
        /// <param int name="Id"></param>
        /// <returns string></returns>
        public async Task<string> DeleteMilk(int id)
        {
                if (id != 0)
                {
                    if (_db.MilkTypes.Where(s => s.Id == id).Any())
                    {
						try
						{
                            var x = _db.MilkTypes.Find(id);
                            _db.MilkTypes.Remove(x);
                            await _db.SaveChangesAsync();
                            return "Milk type has been deleted from the table";
                        }
						catch (Exception)
						{
							throw;
						}   
                    }
                }
                return "Id is not exist";
        }

       

        /// <summary>
        /// To read the list 
        /// </summary>
        /// <returns list></returns>
        public async Task<List<MilkType>> ReadMilkTable()
        {
            return await _db.MilkTypes.ToListAsync();
        }
        /// <summary>
        /// Read the data when the DisableData is true
        /// </summary>
        /// <returns list></returns>
        public async Task<List<MilkType>> ReadDisableMilkData()
        {

            return await _db.MilkTypes.Where(s => s.DisableData == true).ToListAsync();

        }

        /// <summary>
        /// To switch the DisableData between true and false
        /// </summary>
        /// <param int name="id"></param>
        /// <returns></returns>
        public async Task ChangeMilkAvailability(int id)
        {
            if (_db.MilkTypes.Any(x => x.Id == id))
            {
				try
				{
                    var a = _db.MilkTypes.Find(id);
                    a.DisableData = !a.DisableData;
                    await _db.SaveChangesAsync();
                }
				catch (Exception)
				{
					throw;
				}
            }
        }
   

        /// <summary>
        /// To update items in the list
        /// </summary>
        /// <param int name="x"></param>
        /// <returns MilkType></returns>
        public async Task<MilkType> UpdateMilk(int x)
        {
                if (x != 0)
                {
                    if (_db.MilkTypes.Where(s => s.Id == x).Any())
                    {
						try
						{
                            var m = _db.MilkTypes.Find(x);
                            await _db.SaveChangesAsync();
                            return m;
                        }
						catch (Exception)
						{
							throw;
						}                       
                    }
                }
                return null;         
        }




        /// <summary>
        /// To view items and their details
        /// </summary>
        /// <param int name="milkId"></param>
        /// <returns MilkType></returns>
        public async Task<MilkType> MilkCustomerDetails(int milkId)
        {
                if (_db.MilkTypes.Where(a => a.Id == milkId).Any())
                {
					try
					{
                        var milkType = await _db.MilkTypes.FindAsync(milkId);
                        return milkType;
                    }
					catch (Exception)
					{
						throw;
					}                  
                }
                return null;
        }



       
        /// <summary>
        /// To search for items that have prices between 5 and 6
        /// </summary>
        /// <returns list></returns>

        public async Task<List<MilkType>> SortByPrice()
        {
            try
            {
                return await _db.MilkTypes.Where(x => x.Price >= 5 && x.Price <= 6).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }


        // Food page functions

        /// <summary>
        /// To cerate food item to the database
        /// set the DisableData to be true by default
        /// </summary>
        /// <param FoodMenu name="name"></param>
        /// <returns int></returns>

        public async Task<int> CreateFood(FoodMenu name)
        {
           
                if (name != null)
                {
                    if (!_db.FoodTypes.Where(r => r.FoodName == name.FoodName).Any())
                    {
                        if (name.DisableData == false)
                        {
                            name.DisableData = true;
                        }
						try
						{
                            _db.FoodTypes.Add(name);
                            await _db.SaveChangesAsync();
                           return name.Id;
                        }
						catch (Exception)
						{
							throw;
						}
                        
                    }
                }
            return 0;
        }

        /// <summary>
        /// Delete item from the database
        /// </summary>
        /// <param int name="d"></param>
        /// <returns string></returns>
        public async Task<string> DeleteFood(int d)
        {
                if (d != 0)
                {
                    if (_db.FoodTypes.Where(a => a.Id == d).Any())
                    {
						try
						{
                            var y = _db.FoodTypes.Find(d);
                            _db.FoodTypes.Remove(y);
                            await _db.SaveChangesAsync();
                            return "The dish has been deleted";
                        }
						catch (Exception)
						{
							throw;
						}
                    }
                }
                return "Error";            
        }


        /// <summary>
        /// Read data from the database
        /// </summary>
        /// <returns list></returns>
        public async Task<List<FoodMenu>> ReadFoodTable()
        {
            return await _db.FoodTypes.ToListAsync();
        }



        /// <summary>
        /// Read data when the disableData = true
        /// </summary>
        /// <returns list></returns>
        public async Task<List<FoodMenu>> ReadDisableFoodData()
        {
            return await (_db.FoodTypes.Where(r => r.DisableData == true)).ToListAsync();
        }


        /// <summary>
        /// To swich the Disabledata between true and false
        /// </summary>
        /// <param int name="d"></param>
        /// <returns></returns>
        public async Task FoodAvialability(int d)
        {
            if (d != 0)
            {
				try
				{
                    var a = _db.FoodTypes.Find(d);
                    a.DisableData = !a.DisableData;
                    await _db.SaveChangesAsync();
                }
				catch (Exception)
				{
					throw;
				}
               
            }

        }


        /// <summary>
        /// To update items in the database
        /// </summary>
        /// <param int name="id"></param>
        /// <returns FoodMenu></returns>
        public async Task<FoodMenu> UpdateFood(int id)
        {         
                if (id != 0)
                {
                    if (_db.FoodTypes.Where(a => a.Id == id).Any())
                    {
						try
						{
                            var g = _db.FoodTypes.Find(id);
                            await _db.SaveChangesAsync();
                            return g;
                        }
						catch (Exception)
						{
							throw;
						}                     
                    }
                }
                return null;   
        }

        /// <summary>
        /// Find the items and view their details
        /// </summary>
        /// <param int name="id"></param>
        /// <returns FoodMenu></returns>
        public async Task<FoodMenu> FoodCustomerDetail(int id)
        {          
                if (_db.FoodTypes.Where(a => a.Id == id).Any())
                {
					try
					{
                        var food = await _db.FoodTypes.FindAsync(id);
                        return food;
                    }
					catch (Exception)
					{
						throw;
					}                   
                }
                return null;         
        }


        // Tea Page Functions

        /// <summary>
        /// To Add items to the database
        /// </summary>
        /// <param TeaName name="tea"></param>
        /// <returns int></returns>
        public async Task<int> CreateTea(TeaMenu tea)
        {
            if (tea != null)
            {
                if (!_db.TeaTypes.Where(a => a.TeaName == tea.TeaName).Any())
                {
                    if (!tea.DisableData)
                    {
                        tea.DisableData = true;
                    }
                    try
                    {
                        await _db.TeaTypes.AddAsync(tea);
                        await _db.SaveChangesAsync();
                        return tea.Id;
                    }

                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return 0;
        }


        /// <summary>
        /// To read teaMenu
        /// </summary>
        /// <returns list TeaMenu></returns>
        public async Task<List<TeaMenu>> ReadTea()
        {
            return await _db.TeaTypes.ToListAsync();
        }


        /// <summary>
        /// To delete items from tea list
        /// </summary>
        /// <param int name="id"></param>
        /// <returns string></returns>
        public async Task<string> DeleteTea(int id)
        {
            if (id != 0)
            {
                if (_db.TeaTypes.Where(a => a.Id == id).Any())
                {
                    try
                    {
                        var x = _db.TeaTypes.Find(id);
                        _db.TeaTypes.Remove(x);
                        await _db.SaveChangesAsync();
                        return "The tea has been deleted";
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return "Error";
        }


        /// <summary>
        /// To update data in the tea list
        /// </summary>
        /// <param int name="id"></param>
        /// <returns TeaMenu></returns>
        public async Task<TeaMenu> UpdateTea(int id)
        {
            if (id != 0)
            {
                if (_db.TeaTypes.Where(a => a.Id == id).Any())
                {
                    try
                    {
                        var x = _db.TeaTypes.Find(id);
                        await _db.SaveChangesAsync();
                        return (x);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return null;
        }


        /// <summary>
        /// To read data when the DisableData is true
        /// </summary>
        /// <returns list TeaMenu></returns>
        public async Task<List<TeaMenu>> ReadDisableTea()
        {
            return await (_db.TeaTypes.Where(r => r.DisableData == true)).ToListAsync();
        }


        /// <summary>
        /// To return the tea menu 
        /// </summary>
        /// <param int name="teaId"></param>
        /// <returns TeaMenu></returns>
        public async Task<TeaMenu> CustomerTeaDetails(int teaId)
        {
            if (_db.TeaTypes.Where(a => a.Id == teaId).Any())
            {
                try
                {
                    var teaType = await _db.TeaTypes.FindAsync(teaId);
                    return teaType;
                }

                catch (Exception)
                {
                    throw;
                }
            }
            return null;

        }


        /// <summary>
        /// To switch the DisableData between true and false
        /// </summary>
        /// <param int name="id"></param>
        public async Task TeaChangeAvialability(int id)
        {
            if (id != 0)
            {
                var a = _db.TeaTypes.Find(id);
                a.DisableData = !a.DisableData;
                await _db.SaveChangesAsync();
            }
        }

        // Syrup Page Functions

        /// <summary>
        /// To create syrup items to the database 
        /// </summary>
        /// <param SyrupMenu name="syrup"></param>
        /// <returns int></returns>
        public async Task<int> CreateSyrup(SyrupMenu syrup)
        {
            if (syrup != null)
            {
                if (!_db.SyrupTypes.Where(a => a.SyrupName == syrup.SyrupName).Any())
                {
                    if (!syrup.DisableData)
                    {
                        syrup.DisableData = true;
                    }
                    try
                    {
                        await _db.SyrupTypes.AddAsync(syrup);
                        await _db.SaveChangesAsync();
                        return syrup.Id;
                    }

                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return 0;
        }


        /// <summary>
        /// To read data from the database
        /// </summary>
        /// <returns list SyrupMenu></returns>
        public async Task<List<SyrupMenu>> ReadSyrup()
        {
            return await _db.SyrupTypes.ToListAsync();
        }

        /// <summary>
        /// To delete syrup from the syrup list
        /// </summary>
        /// <param int name="id"></param>
        /// <returns string></returns>
        public async Task<string> DeleteSyrup(int id)
        {
            if (id != 0)
            {
                if (_db.SyrupTypes.Where(a => a.Id == id).Any())
                {
                    try
                    {
                        var x = _db.SyrupTypes.Find(id);
                        _db.SyrupTypes.Remove(x);
                        await _db.SaveChangesAsync();

                        return "The syrup has been deleted";
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return "Error";
        }


        /// <summary>
        /// Update syrup item
        /// </summary>
        /// <param int name="id"></param>
        /// <returns SyruoMenu></returns>
        public async Task<SyrupMenu> UpdateSyrup(int id)
        {
            if (id != 0)
            {
                if (_db.SyrupTypes.Where(a => a.Id == id).Any())
                {
                    try
                    {
                        var x = _db.SyrupTypes.Find(id);
                        await _db.SaveChangesAsync();

                        return (x);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }

            }
            return null;
        }



        /// <summary>
        /// Read syrup when the DisableData is true
        /// </summary>
        /// <returns list SyrupMenu></returns>
        public async Task<List<SyrupMenu>> ReadDisableSyrup()
        {
            return await (_db.SyrupTypes.Where(r => r.DisableData == true)).ToListAsync();
        }


        /// <summary>
        /// To switch DisableData between true and false
        /// </summary>
        /// <param int name="id"></param>
        public async Task SyrupChangeAvialability(int id)
        {
            if (id != 0)
            {
                var a = _db.SyrupTypes.Find(id);
                a.DisableData = !a.DisableData;
                await _db.SaveChangesAsync();
            }
        }


        /// <summary>
        /// To 
        /// </summary>
        /// <param int name="syrupId"></param>
        /// <returns SyrupMenu></returns>
        public async Task<SyrupMenu> CustomerSyrupDetails(int syrupId)
        {
            if (_db.SyrupTypes.Where(a => a.Id == syrupId).Any())
            {
                try
                {
                    var syrupType = await _db.SyrupTypes.FindAsync(syrupId);
                    return syrupType;
                }

                catch (Exception)
                {
                    throw;
                }
            }
            return null;

        }


        // Sweetener Page Functions

        /// <summary>
        ///creat sweetener item to the database  
        /// </summary>
        /// <param SweetenerMenu name="sweet"></param>
        /// <returns int></returns>
        public async Task<int> CreateSweetener(SweetenerMenu sweet)
        {
            if (sweet != null)
            {
                if (!_db.SweetenerTypes.Where(a => a.SweetenerName == sweet.SweetenerName).Any())
                {
                    if (!sweet.DisableData)
                    {
                        sweet.DisableData = true;
                    }

                    try
                    {
                        await _db.SweetenerTypes.AddAsync(sweet);
                        await _db.SaveChangesAsync();
                        return sweet.Id;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return 0;
        }


        /// <summary>
        /// to read from the database
        /// </summary>
        /// <returns list SweetenerMenu></returns>
        public async Task<List<SweetenerMenu>> ReadSweetener()
        {
            return await _db.SweetenerTypes.ToListAsync();
        }


        /// <summary>
        /// delete sweetener item from the list
        /// </summary>
        /// <param int name="id"></param>
        /// <returns string></returns>
        public async Task<string> DeleteSweetener(int id)
        {
            if (id != 0)
            {
                if (_db.SweetenerTypes.Where(a => a.Id == id).Any())
                {
                    try
                    {
                        var x = _db.SweetenerTypes.Find(id);
                        _db.SweetenerTypes.Remove(x);
                        await _db.SaveChangesAsync();

                        return "The sweetener has been deleted";
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return "Error";
        }


        /// <summary>
        /// update sweetener items 
        /// </summary>
        /// <param int name="id"></param>
        /// <returns SweetenerMenu></returns>
        public async Task<SweetenerMenu> UpdateSweetener(int id)
        {
            if (id != 0)
            {
                if (_db.SweetenerTypes.Where(a => a.Id == id).Any())
                {
                    try
                    {
                        var x = _db.SweetenerTypes.Find(id);
                        await _db.SaveChangesAsync();

                        return (x);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }

            }
            return null;
        }


        /// <summary>
        /// read when the DisableData = true
        /// </summary>
        /// <returns list SweetenerMenu></returns>
        public async Task<List<SweetenerMenu>> ReadDisableSweetener()
        {
            return await (_db.SweetenerTypes.Where(r => r.DisableData == true)).ToListAsync();
        }


        /// <summary>
        /// switch the DisableData between true and false
        /// </summary>
        /// <param int name="id"></param>
        public async Task SweetenerChangeAvialability(int id)
        {
            if (id != 0)
            {
                var a = _db.SweetenerTypes.Find(id);
                a.DisableData = !a.DisableData;
                await _db.SaveChangesAsync();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param int name="sweetenerId"></param>
        /// <returns SweetenerMenu></returns>
        public async Task<SweetenerMenu> CustomerSweetenerDetails(int sweetenerId)
        {
            if (_db.SweetenerTypes.Where(a => a.Id == sweetenerId).Any())
            {
                try
                {
                    var sweetType = await _db.SweetenerTypes.FindAsync(sweetenerId);
                    return sweetType;
                }

                catch (Exception)
                {
                    throw;
                }
            }
            return null;

        }

        // Topping Page Functions


        /// <summary>
        /// to create topping item to the database
        /// </summary>
        /// <param ToppingMenu name="top"></param>
        /// <returns int></returns>
        public async Task<int> CreateTopping(ToppingMenu top)
        {
            if (top != null)
            {
                if (!_db.ToppingTypes.Where(a => a.ToppingName == top.ToppingName).Any())
                {
                    if (!top.DisableData)
                    {
                        top.DisableData = true;
                    }

                    try
                    {
                        await _db.ToppingTypes.AddAsync(top);
                        await _db.SaveChangesAsync();
                        return top.Id;
                    }

                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return 0;
        }


        /// <summary>
        /// to read from the database
        /// </summary>
        /// <returns list ToppingMenu></returns>
        public async Task<List<ToppingMenu>> ReadTopping()
        {
            return await _db.ToppingTypes.ToListAsync();
        }


        /// <summary>
        /// to delete topping item from the list
        /// </summary>
        /// <param int name="id"></param>
        /// <returns string></returns>
        public async Task<string> DeleteTopping(int id)
        {
            if (id != 0)
            {
                if (_db.ToppingTypes.Where(a => a.Id == id).Any())
                {
                    try
                    {
                        var x = _db.ToppingTypes.Find(id);
                        _db.ToppingTypes.Remove(x);
                        await _db.SaveChangesAsync();

                        return "The topping has been deleted";
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return "Error";
        }


        /// <summary>
        /// to update topping items 
        /// </summary>
        /// <param int name="id"></param>
        /// <returns ToppingMenu></returns>
        public async Task<ToppingMenu> UpdateTopping(int id)
        {
            if (id != 0)
            {
                if (_db.ToppingTypes.Where(a => a.Id == id).Any())
                {
                    try
                    {
                        var x = _db.ToppingTypes.Find(id);
                        await _db.SaveChangesAsync();
                        return (x);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }

            }
            return null;
        }


        /// <summary>
        /// read data when DisableData = true
        /// </summary>
        /// <returns list ToppingMenu></returns>
        public async Task<List<ToppingMenu>> ReadDisableTopping()
        {
            return await (_db.ToppingTypes.Where(r => r.DisableData == true)).ToListAsync();
        }


        /// <summary>
        /// to switch the DisadleData between true and false
        /// </summary>
        /// <param int name="id"></param>
       
        public async Task ToppingChangeAvialability(int id)
        {
            if (id != 0)
            {
                var a = _db.ToppingTypes.Find(id);
                a.DisableData = !a.DisableData;
                await _db.SaveChangesAsync();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param int name="TopperId"></param>
        /// <returns ToppingMenu></returns>
        public async Task<ToppingMenu> CustomerToppingDetails(int TopperId)
        {
            if (_db.ToppingTypes.Where(a => a.Id == TopperId).Any())
            {
                try
                {
                    var TopType = await _db.ToppingTypes.FindAsync(TopperId);
                    return TopType;
                }

                catch (Exception)
                {
                    throw;
                }
            }
            return null;

        }

        // Drink Page Functions


        /// <summary>
        /// to create drink items to the drink table
        /// </summary>
        /// <param DrinkMenu name="drink"></param>
        /// <returns int></returns>
        public async Task<int> CreateDrink(DrinkMenu drink)
        {
            if (drink != null)
            {
                if (!_db.DrinkTypes.Where(a => a.DrinkName == drink.DrinkName).Any())
                {
                    if (!drink.DisableData)
                    {
                        drink.DisableData = true;
                    }
                    try
                    {
                        await _db.DrinkTypes.AddAsync(drink);
                        await _db.SaveChangesAsync();
                        return drink.Id;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return 0;

        }


        /// <summary>
        /// to read drinks table
        /// </summary>
        /// <returns list DrinkMenu></returns>
        public async Task<List<DrinkMenu>> ReadDrink()
        {
            return await _db.DrinkTypes.ToListAsync();
        }


        /// <summary>
        /// to delete items from drinks table
        /// </summary>
        /// <param int name="id"></param>
        /// <returns string></returns>
        public async Task<string> DeleteDrink(int id)
        {
            if (id != 0)
            {
                if (_db.DrinkTypes.Where(a => a.Id == id).Any())
                {
                    try
                    {
                        var x = _db.DrinkTypes.Find(id);
                        _db.DrinkTypes.Remove(x);
                        await _db.SaveChangesAsync();

                        return "The drink has been deleted";
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return "Error";
        }


        /// <summary>
        /// update drink items
        /// </summary>
        /// <param int name="id"></param>
        /// <returns DrinkMenu></returns>
        public async Task<DrinkMenu> UpdateDrink(int id)
        {
            if (id != 0)
            {
                if (_db.DrinkTypes.Where(a => a.Id == id).Any())
                {
                    try
                    {
                        var x = _db.DrinkTypes.Find(id);
                        await _db.SaveChangesAsync();

                        return (x);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }

            }
            return null;
        }


        /// <summary>
        /// Read items when the disableData is true
        /// </summary>
        /// <returns list of DrinkMenu></returns>
        public async Task<List<DrinkMenu>> ReadDisableDrink()
        {
            return await (_db.DrinkTypes.Where(r => r.DisableData == true)).ToListAsync();
        }


        /// <summary>
        /// To switch the DisableData between true and false
        /// </summary>
        /// <param int name="id"></param>
        public async Task DrinkChangeAvialability(int id)
        {
            if (id != 0)
            {
                var a = _db.DrinkTypes.Find(id);
                a.DisableData = !a.DisableData;
                await _db.SaveChangesAsync();
            }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param int name="DrinkId"></param>
        /// <returns DrinkMenu></returns>
        public async Task<DrinkMenu> CustomerDrinkDetails(int DrinkId)
        {
            if (_db.DrinkTypes.Where(a => a.Id == DrinkId).Any())
            {
                try
                {
                    var drinkType = await _db.DrinkTypes.FindAsync(DrinkId);
                    return drinkType;
                }

                catch (Exception)
                {
                    throw;
                }
            }
            return null;

        }

        /// <summary>
        /// To update the milk in another projects
        /// </summary>
        /// <param name="milk"></param>
        /// <returns int></returns>
        public async Task<int> UpdateMilk_New(MilkType milk)
        {
            if (milk != null)
            {
                try
                {
                    var milkObj = await _db.MilkTypes.FindAsync(milk.Id);
                    milkObj.Name = milk.Name;
                    milkObj.Price = milk.Price;
                    milkObj.Description = milkObj.Description;
                    await _db.SaveChangesAsync();
                    return milkObj.Id;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return 0;
        }


    }
}


