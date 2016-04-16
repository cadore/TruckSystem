using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;
using TruckSystem.Utils;
using TruckSystem.Connection;

namespace TruckSystem
{

	public partial class TruckSystemRepo : Database
	{
        public TruckSystemRepo() : base(ConnectionUtil.ConnectionString, ConnectionUtil.InvariantName)
		{
			CommonConstruct();
		}

		public TruckSystemRepo(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			TruckSystemRepo GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static TruckSystemRepo GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new TruckSystemRepo();
        }

		[ThreadStatic] static TruckSystemRepo _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
			public static TruckSystemRepo repo { get { return TruckSystemRepo.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }
            public static String Concat(object s) { return String.Format("%{0}%", s); }
            public static DateTime Now() 
            {
                bool web = Util.isConnectedWeb();
                if (web)
                {
                    try
                    {
                        return Dates.getUTCDateTime();
                    }
                    catch (Exception)
                    {
                        return repo.ExecuteScalar<DateTime>("SELECT LOCALTIMESTAMP");
                    }
                }                    
                else
                    return repo.ExecuteScalar<DateTime>("SELECT LOCALTIMESTAMP");
            }

		}

	}


    [TableName("business")]
    [PrimaryKey("id")]
    [ExplicitColumns]
    public partial class business : TruckSystemRepo.Record<business>
    {
        [Column]
        public long id { get; set; }
    }

    
	[TableName("users")]
	[PrimaryKey("id")]
	[ExplicitColumns]
    public partial class user : TruckSystemRepo.Record<user>  
    {
		[Column] public long id { get; set; }





		[Column] public string full_name { get; set; }





		[Column] public string password { get; set; }





		[Column] public string cpf { get; set; }





		[Column] public bool inactive { get; set; }





		[Column] public bool admin { get; set; }





		[Column] public bool money { get; set; }



	}

    
	[TableName("address")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class address : TruckSystemRepo.Record<address>  
    {



		[Column] public long id { get; set; }





		[Column] public string name { get; set; }





		[Column] public string district { get; set; }





		[Column] public long city_id { get; set; }





		[Column] public long state_id { get; set; }





		[Column] public string number { get; set; }





		[Column] public string complement { get; set; }





		[Column] public string cep { get; set; }



	}

    
	[TableName("city")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class city : TruckSystemRepo.Record<city>  
    {



		[Column] public int id { get; set; }





		[Column] public string name { get; set; }





		[Column] public int cod_ibge { get; set; }





		[Column] public int state_id { get; set; }





		[Column] public int population { get; set; }





		[Column] public decimal demographic { get; set; }





		[Column] public string gentilic { get; set; }





		[Column] public decimal area { get; set; }





		[Column] public string zip_code { get; set; }



	}

    
	[TableName("states")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class state : TruckSystemRepo.Record<state>  
    {



		[Column] public int id { get; set; }





		[Column] public string name { get; set; }





		[Column] public string symbol { get; set; }



	}

    
	[TableName("trailers")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class trailer : TruckSystemRepo.Record<trailer>  
    {



		[Column] public long id { get; set; }





		[Column] public string board { get; set; }





		[Column] public string renavam { get; set; }





		[Column] public string chassi { get; set; }





		[Column] public string mark { get; set; }





		[Column] public string model { get; set; }





		[Column] public int? year_fabrication { get; set; }





		[Column] public int? year_model { get; set; }





		[Column] public long registred_by { get; set; }





		[Column] public DateTime? registred_at { get; set; }





		[Column] public string color { get; set; }





		[Column] public long truck_id { get; set; }





		[Column] public long index { get; set; }

        [Column] public int? antt { get; set; }



	}

    
	[TableName("customers")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class customer : TruckSystemRepo.Record<customer>  
    {



		[Column] public long id { get; set; }





		[Column] public string corporate_name { get; set; }





		[Column] public string fantasy_name { get; set; }





		[Column] public string document { get; set; }



        [Column] public int type { get; set; }



		[Column] public long address_id { get; set; }





		[Column] public DateTime? registred_at { get; set; }





		[Column] public long registred_by { get; set; }





		[Column] public bool inactive { get; set; }





		[Column] public string ie_rg { get; set; }





		[Column] public string phone_fixed { get; set; }





		[Column] public string phone_mobile { get; set; }



	}

    
	[TableName("bank_accounts")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class bank_account : TruckSystemRepo.Record<bank_account>  
    {



		[Column] public long id { get; set; }





		[Column] public long number_bank { get; set; }





		[Column] public string name_bank { get; set; }





		[Column] public string agency { get; set; }





		[Column] public string account { get; set; }





		[Column] public string holder { get; set; }





		[Column] public string document { get; set; }





		[Column] public DateTime? registred_at { get; set; }





		[Column] public long registred_by { get; set; }



	}

    
	[TableName("logins")]
    [PrimaryKey("id")]
	[ExplicitColumns]
    public partial class logins : TruckSystemRepo.Record<logins>  
    {



		[Column] public long id { get; set; }





		[Column] public long user_id { get; set; }





		[Column] public string host { get; set; }





		[Column] public DateTime? date { get; set; }





		[Column] public string local_ip { get; set; }





		[Column] public string external_ip { get; set; }



	}

    
	[TableName("outputs")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class output : TruckSystemRepo.Record<output>  
    {



		[Column] public long id { get; set; }





		[Column] public string description { get; set; }





		[Column] public string observation { get; set; }





		[Column] public long customer_id { get; set; }


        public string customer_name { get; set; }


		[Column] public long truck_id { get; set; }





		[Column] public long freight_id { get; set; }





		[Column] public DateTime? registred_at { get; set; }





		[Column] public long registred_by { get; set; }





		[Column] public DateTime? date { get; set; }





		[Column] public decimal value { get; set; }



	}


    [TableName("trucks")]


    [PrimaryKey("id")]



    [ExplicitColumns]
    public partial class truck : TruckSystemRepo.Record<truck>
    {



        [Column]
        public long id { get; set; }





        [Column]
        public string board { get; set; }





        [Column]
        public string renavam { get; set; }





        [Column]
        public string chassi { get; set; }





        [Column]
        public string mark { get; set; }





        [Column]
        public string model { get; set; }





        [Column]
        public int? year_fabrication { get; set; }





        [Column]
        public int? year_model { get; set; }





        [Column]
        public long registred_by { get; set; }





        [Column]
        public DateTime? registred_at { get; set; }
        [Column] public string color { get; set; }
        [Column] public long driver_id { get; set; }
        [Column] public int? antt { get; set; }

        public string driver_name { get; set; }



    }
    
	[TableName("stays")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class stay : TruckSystemRepo.Record<stay>  
    {



		[Column] public long id { get; set; }





		[Column] public long freight_id { get; set; }





		[Column] public long truck_id { get; set; }





		[Column] public long driver_id { get; set; }





		[Column] public long registred_by { get; set; }





		[Column] public DateTime? registred_at { get; set; }





		[Column] public DateTime? start { get; set; }





		[Column] public DateTime? end { get; set; }





		[Column] public decimal value_hor { get; set; }


        [Column] public decimal total { get; set; }


        [Column] public decimal taxe_comission { get; set; }


        [Column]
        public decimal total_comission { get; set; }

	}

    
	[TableName("payments")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class payment : TruckSystemRepo.Record<payment>  
    {
		[Column] public long id { get; set; }
        [Column] public long account_id { get; set; }
		[Column] public string description { get; set; }
		[Column] public DateTime? expiration_date { get; set; }
		[Column] public DateTime? paid_date { get; set; }
        [Column] public decimal value { get; set; }
		[Column] public decimal value_paid { get; set; }
		[Column] public string observation { get; set; }
		[Column] public long customer_id { get; set; }
		[Column] public long truck_id { get; set; }
		[Column] public long freight_id { get; set; }
		[Column] public string reason_expiration { get; set; }
		[Column] public bool paid { get; set; }
        [Column] public bool is_payment { get; set; }
		[Column] public DateTime? registred_at { get; set; }
		[Column] public long registred_by { get; set; }
        [Column] public string guid { get; set; }
        [Column] public int category_id { get; set; }

        public string customer_name { get; set; }
        public string truck_board { get; set; }
	}

    
	[TableName("drivers")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class driver : TruckSystemRepo.Record<driver>  
    {



		[Column] public long id { get; set; }





		[Column] public string full_name { get; set; }





		[Column] public string cpf { get; set; }





		[Column] public long address { get; set; }





		[Column] public DateTime? birthday { get; set; }



        [Column] public DateTime? expiration_cnh { get; set; }



		[Column] public string number_cnh { get; set; }





		[Column] public string category_cnh { get; set; }





		[Column] public int genre { get; set; }





		[Column] public string phone_fixed { get; set; }





		[Column] public string phone_mobile { get; set; }





		[Column] public bool inactive { get; set; }





		[Column] public DateTime? registred_at { get; set; }





		[Column] public long registred_by { get; set; }





		[Column] public decimal comission { get; set; }





		[Column] public DateTime? admitted_at { get; set; }





		[Column] public DateTime? dismissed_at { get; set; }
        [Column] public string naturalness { get; set; }
        [Column] public string register_cnh { get; set; }
        [Column] public string mother_name { get; set; }



	}

    
	[TableName("fueleds")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class fueled : TruckSystemRepo.Record<fueled>  
    {



		[Column] public long id { get; set; }





		[Column] public long freight_id { get; set; }





		[Column] public long truck_id { get; set; }





		[Column] public long driver_id { get; set; }





		[Column] public DateTime? date { get; set; }





		[Column] public string km { get; set; }





		[Column] public long gas_station_id { get; set; }





		[Column] public decimal liters { get; set; }





		[Column] public decimal value_liters { get; set; }





		[Column] public decimal discount { get; set; }



        [Column] public decimal total { get; set; }

		[Column] public DateTime? registred_at { get; set; }





		[Column] public long registred_by { get; set; }


        public string gas_station_name { get; set; }

	}

    
	[TableName("freights")]
	[PrimaryKey("id")]
	[ExplicitColumns]
    public partial class freight : TruckSystemRepo.Record<freight>  
    {
		[Column] public long id { get; set; }
		[Column] public DateTime? registred_at { get; set; }
        [Column] public long registred_by { get; set; }
		[Column] public bool inactive { get; set; }
		[Column] public long truck_id { get; set; }
		[Column] public long driver_id { get; set; }
		[Column] public int? number_note { get; set; }
		[Column] public int? number_cte { get; set; }
		[Column] public long company_source { get; set; }
		[Column] public long company_destination { get; set; }
        [Column] public long carrier { get; set; }
		[Column] public string product { get; set; }
		[Column] public DateTime? start { get; set; }
		[Column] public DateTime? end { get; set; }
		[Column] public decimal weight { get; set; }
        [Column] public decimal value_ton { get; set; }
        [Column] public decimal value_comission { get; set; }
        [Column] public decimal taxe_comission { get; set; }
		[Column] public decimal discounts_comission { get; set; }
		[Column] public decimal extra_comission { get; set; }
		[Column] public string observations { get; set; }
        [Column] public string trailers { get; set; }
        
        public string company_source_name { get; set; }
        public string company_destination_name { get; set; }
        public decimal total { get; set; }
        public decimal total_fueled { get; set; }
        public string truck_board { get; set; }
        public string viewStay { get; set; }
        public string driver_name { get; set; }
	}

    [TableName("accounts_to_pay")]
    [PrimaryKey("id")]
    [ExplicitColumns]
    public partial class accounts_to_pay : TruckSystemRepo.Record<accounts_to_pay>
    {
        [Column] public long id { get; set; }
        [Column] public string description { get; set; }
        [Column] public string chave { get; set; }
        [Column] public string number { get; set; }
        [Column] public int serie { get; set; }
        [Column] public long customer_id { get; set; }
        [Column] public DateTime? emission_at { get; set; }
        [Column] public decimal value_products { get; set; }
        [Column] public decimal value_freight { get; set; }
        [Column] public decimal value_security { get; set; }
        [Column] public decimal value_discount { get; set; }
        [Column] public decimal value_ipi { get; set; }
        [Column] public string observations { get; set; }
        [Column] public long registred_by { get; set; }
        [Column] public DateTime registred_at { get; set; }
        [Column] public string guid_payment { get; set; }
        [Column] public long truck_id { get; set; }
        [Column] public int category_id { get; set; }
    }

    [TableName("categorys")]
    [PrimaryKey("id")]
    [ExplicitColumns]
    public partial class category : TruckSystemRepo.Record<category>
    {
        [Column] public long id { get; set; }
        [Column] public string name { get; set; }
        [Column] public int type { get; set; }

        public enum Categorys
        {
            Payment = 0,
        }
    }
}