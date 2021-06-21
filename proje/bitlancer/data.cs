using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bitlancer
{
	public sealed class SingletonDB
	{
		private static SingletonDB instance = null;

		public static SingletonDB GetInstance
		{
			get
			{
				if (instance == null)
					instance = new SingletonDB();
				return instance;
			}
		}

		private SingletonDB()
		{
		}
		public MySqlConnection getConnection()
		{
			MySqlConnection connection = null;
			try
			{
				connection = new MySqlConnection("server=localhost;port=3307;user=root;pwd=;database=aesfinal;charset=utf8;pooling=false");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			return connection;
		}
		public int getId(string sql)
		{
			int id = 0;
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				connection = getConnection();
				connection.Open();
				command = new MySqlCommand(sql, connection);
				id = Convert.ToInt32(command.ExecuteScalar());
				command.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return id;
		}
		public double getDouble(string sql)
		{
			double val = 0;
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				connection = getConnection();
				connection.Open();
				command = new MySqlCommand(sql, connection);
				MySqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					val = Convert.ToDouble(reader[0]);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return val;
		}
		public int updateitem(int id)
		{
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				connection = getConnection();
				connection.Open();
				Random rnd = new Random();
				command = new MySqlCommand("update item_user_infos set unit_price=" + id + " where id=6", connection);
				command.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return id;
		}
		public int loginCheck(string userName, string password)
		{
			bool state = false;
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				connection = getConnection();
				connection.Open();
				command = new MySqlCommand("select user_name, user_password from users", connection);
				command.Connection = connection;
				MySqlDataReader read = command.ExecuteReader();
				while (read.Read())
				{
					if (read[0].ToString() == userName && read[1].ToString() == password)
					{
						state = true;
						break;

					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("hata: " + e.Message);
			}
			finally
			{
				if (connection != null)
				{
					try
					{
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return state ? getId("select id from users where user_name='" + userName + "'") : 0;

		}
		public item getItem(int id)
		{
			item myItem = new item();
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				connection = getConnection();
				connection.Open();
				command = new MySqlCommand("select * from items where id=" + id, connection);
				MySqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					myItem.id = int.Parse(reader[0].ToString());
					myItem.itemName = reader[1].ToString();
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return myItem;
		}

		public List<item> getItemBitlancer()
		{
			List<item> items = new List<item>();
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				connection = getConnection();
				connection.Open();
				command = new MySqlCommand("select * from items", connection);
				command.Connection = connection;
				MySqlDataReader read = command.ExecuteReader();
				while (read.Read())
				{
					item urun = new item();
					urun.id = Convert.ToInt32(read[0]);
					urun.itemName = read[1].ToString();
					items.Add(urun);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("hata: " + e.Message);
			}
			finally
			{
				if (connection != null)
				{
					try
					{
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return items;
		}
		public DataTable getItems()
		{
			DataTable dt = new DataTable();
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				connection = getConnection();
				connection.Open();
				command = new MySqlCommand("select (row_number() over (order by i.item_name))as 'No:', i.item_name as 'Para Birimi:',concat(min(f.unit_price),' ₺') as 'Biriim Fiyat:',i.id from items i, item_user_infos f where  i.id=f.item_id and i.id!=4 and f.selling=1 GROUP by f.item_id order by i.item_name", connection);
				dt.Load(command.ExecuteReader());
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return dt;
		}
		public item getItemOrder(int id, int userID)
		{
			item urun = new item();
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				connection = getConnection();
				connection.Open();
				command = new MySqlCommand("select item_id, min(unit_price), sum(quantity),(select item_name from items where id=s.item_id) from item_user_infos s where selling=1 and item_id=" + id, connection);
				command.Connection = connection;
				MySqlDataReader read = command.ExecuteReader();
				while (read.Read())
				{
					urun.id = Convert.ToInt32(read[0]);
					urun.unitPrice = Convert.ToDouble(read[1]);
					urun.quantity = Convert.ToInt32(read[2]);
					urun.itemName = read[3].ToString();
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("hata: " + e.Message);
			}
			finally
			{
				if (connection != null)
				{
					try
					{
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return urun;
		}
		public DataTable getItemTransfers(int id)
		{
			DataTable dt = new DataTable();
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				connection = getConnection();
				connection.Open();
				command = new MySqlCommand("select (row_number() over (order by f.id desc))as 'No:', i.item_name as 'Ürün:',concat(min(f.unit_price),' ₺') as 'Birim Fiyat:',f.quantity as 'Adet:', f.date as 'Tarih:',f.state as 'Durum:',f.description as 'Açıklama:' from items i, item_adds f where  i.id=f.item_id and f.user_id=" + id + " GROUP by f.item_id", connection);
				dt.Load(command.ExecuteReader());
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return dt;
		}
		public bool setItemTransfer(int userID, int itemID, int quantity)
		{
			bool state = false;
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				connection = getConnection();
				connection.Open();
				Random rnd = new Random();
				command = new MySqlCommand("insert into item_adds(user_id,item_id,quantity,unit_price,state,description,date) values(" + userID + "," + itemID + "," + quantity + ",1,0,'BEKLENİYOR','" + DateTime.Now.ToString() + "')", connection);
				command.ExecuteNonQuery();
				state = true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				state = false;
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return state;
		}
		public DataTable getLastOrders(int id = 0, int item_id = 0)
		{
			DataTable dt = new DataTable();
			MySqlConnection connection = null;
			MySqlCommand command = null;
			string toUserOrder = "", toAdmin = "", whereClause = "";
			if (id != 0)
			{
				toUserOrder = "(CASE WHEN destination_user_id=" + id + " THEN 'ALIM' ELSE 'SATIM' END) as 'İşlem: ',";
				whereClause = "where " + (item_id != 0 ? "item_id=" + item_id + " and (" : "") + "destination_user_id=" + id + " or source_user_id=" + id + (item_id != 0 ? ")" : "");
			}
			else
			{
				toAdmin = " (select user_full_name from users where id = o.destination_user_id) as 'Hedef:',(select user_full_name from users where id = o.source_user_id) as 'Kaynak: ',";
			}
			try
			{
				connection = getConnection();
				connection.Open();
				command = new MySqlCommand("select row_number() over(order by id desc) as 'No:'," + toUserOrder + " order_date as 'Tarih:'," + toAdmin + " (select item_name from items where id = o.item_id) as 'Ürün:',(order_quantity * order_unit_price) as 'Tutar:',(select quantity from item_user_infos where user_id = " + (id != 0 ? id.ToString() : "o.destination_user_id") + " and item_id = 4) as 'Kalan Para:',order_unit_price as 'Birim Fiyat:' from item_orders o " + whereClause, connection);
				dt.Load(command.ExecuteReader());
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return dt;
		}
		public User getUser(int id)
		{
			User myUser = new User();
			List<item> MyItems = new List<item>();
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				connection = getConnection();
				connection.Open();
				command = new MySqlCommand("select * from item_user_infos inner join items on item_user_infos.item_id=items.id where user_id=" + id, connection);
				MySqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					item tempItem = new item(int.Parse(reader[2].ToString()), reader[7].ToString(), Convert.ToDouble(reader[4].ToString()), int.Parse(reader[3].ToString()), (bool)reader[5]);
					MyItems.Add(tempItem);
				}
				reader.Close();
				command = new MySqlCommand("select * from users where id=" + id, connection);
				reader = command.ExecuteReader();
				while (reader.Read())
				{
					myUser = new User(id, reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString() == "5" ? bitlancer.userTypes.admin : bitlancer.userTypes.basic, MyItems);
				}

			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return myUser;
		}
		public bool setItemOrder(int userIDSource, int userIDDestination, int itemID, int orderQuantity, double unitPrice)
		{
			bool state = false;
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				connection = getConnection();
				connection.Open();
				Random rnd = new Random();
				command = new MySqlCommand("insert into item_orders (destination_user_id,source_user_id,item_id,order_unit_price,order_quantity,order_date) values(" + userIDDestination + "," + userIDSource + "," + itemID + ",'" + unitPrice.ToString().Replace(",", ".") + "'," + orderQuantity + ",'" + DateTime.Now.ToString() + "')", connection);
				command.ExecuteNonQuery();
				state = true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				state = false;
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return state;
		}
		public bool updateAfterOrder(int selling, int sourceID, int itemID, int quantity, double unitPrice = 1, bool delete = false)
		{
			bool state = false;
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				string sorgu;
				if (delete)
				{
					sorgu = "delete from item_user_infos where selling=" + selling + " and (item_id=" + itemID + " and user_id=" + sourceID + ")";
				}
				else
				{
					if (getId("select id from item_user_infos where selling=" + selling + " and (item_id=" + itemID + " and user_id=" + sourceID + ")") != 0)
					{
						sorgu = "update item_user_infos set quantity=" + quantity + " where  selling=" + selling + " and (item_id=" + itemID + " and user_id=" + sourceID + ")";
					}
					else
					{
						sorgu = "insert into item_user_infos (user_id,item_id,quantity,unit_price,selling) values (" + sourceID + "," + itemID + "," + quantity + ",'" + unitPrice.ToString().Replace(",", ".") + "',0)";
					}
				}
				connection = getConnection();
				connection.Open();
				command = new MySqlCommand(sorgu, connection);
				command.ExecuteNonQuery();
				state = true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				state = false;
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return state;
		}

		public bool updateAfterOrderRequest(int source_user_id, int destination_user_id, int item_id, int quantity, double unitPrice, bool source) //bool source kismi guncelleme isinin kaynakta mi hedefte mi yapildigini gosteriyor.
        {
			
			bool state = true;
			
			MySqlCommand command = null;
			MySqlCommand command2 = null;
			MySqlCommand command3 = null;
			MySqlCommand commandControlPriceQuantity = null;
			MySqlConnection connection = null;
			MySqlConnection connection2 = null;
			MySqlDataReader readCommandControlPQ = null;
			double _price=0;
			int _quantity=0;
			double moneyNeeded=0;
			int request_id = 0;
			int sourceTotalMoney = 0;
			try
           {
				
				connection = getConnection();
				connection.Open();
				if(source== true) //source'un itemleri/parasi uzerinde degisiklik yapilacaksa gir.
                {
					try
                    {
						sourceTotalMoney = getId("SELECT quantity FROM item_user_infos WHERE user_id=" + source_user_id + " AND item_id= 4");
						commandControlPriceQuantity = new MySqlCommand("SELECT o.order_request_unit_price, o.order_request_quantity, o.request_id FROM item_user_infos u, item_order_request o, items i WHERE o.state = 0 AND u.selling = 1 AND o.item_id = u.item_id AND o.order_request_unit_price >= u.unit_price AND o.order_request_quantity <= u.quantity GROUP BY u.unit_price", connection);
						readCommandControlPQ = commandControlPriceQuantity.ExecuteReader();

						bool firstPriceSelect = true;
						while (readCommandControlPQ.Read() && firstPriceSelect)
						{
							_price = Convert.ToDouble(readCommandControlPQ[0]);		// gereken total para icin birim fiyat bul.
							_quantity = Convert.ToInt32(readCommandControlPQ[1]);	// gereken total para için miktar bul
							request_id = Convert.ToInt32(readCommandControlPQ[2]);	// request_id bul.
							moneyNeeded = _quantity * _price;						// gereken total para 
							firstPriceSelect = false;
						}
						connection.Close();
						connection2 = getConnection();
						connection2.Open();

						if (sourceTotalMoney < moneyNeeded)
						{
							state = false;
						}
						else
						{
							
							try
							{
								command =  new MySqlCommand("UPDATE item_user_infos SET quantity = quantity - " + moneyNeeded + " WHERE item_id = 4 AND user_id= " + source_user_id, connection2);
								command2 = new MySqlCommand("UPDATE item_user_infos SET quantity = quantity + " + _quantity + " WHERE item_id =" + item_id + " AND user_id= " + source_user_id, connection2);
								command3 = new MySqlCommand("INSERT INTO source_destination_change_log (request_id, item_id, source_user_id, destination_user_id, order_request_unit_price, order_request_quantity, state_source, source_change_date ) VALUES (" + request_id + ", " + item_id + ", " + source_user_id + ", " + destination_user_id + ", " + unitPrice + ", " + quantity + ", 1,'" + DateTime.Now.ToString() + "' )", connection2); 
								command.ExecuteNonQuery(); command2.ExecuteNonQuery(); command3.ExecuteNonQuery();
								// yapilan degisiklikleri database'e kaydettik, istenildigi zaman geri donus islemi yapilabilsin.
								state = true;
							}
							catch (Exception err)
							{
								Console.WriteLine(err.Message);
							}
						}
					}
					catch (Exception err)
                    {
						Console.WriteLine(err.Message);
                    }
					
                }
					
					
				
				else //destination'in itemleri/parasi uzerinde degisiklik yapilacaksa gir.
				{
                    try 
					{
						commandControlPriceQuantity = new MySqlCommand("SELECT o.order_request_unit_price, o.order_request_quantity, o.request_id FROM item_user_infos u, item_order_request o, items i WHERE o.state = 0 AND u.selling = 1 AND o.item_id = u.item_id AND o.order_request_unit_price >= u.unit_price AND o.order_request_quantity <= u.quantity GROUP BY u.unit_price", connection);
						readCommandControlPQ = commandControlPriceQuantity.ExecuteReader();

						bool firstPriceSelect = true;
						while (readCommandControlPQ.Read() && firstPriceSelect)
						{
							_price = Convert.ToDouble(readCommandControlPQ[0]);		// gereken total para icin birim fiyat bul.
							_quantity = Convert.ToInt32(readCommandControlPQ[1]);	// gereken total para için miktar bul
							request_id = Convert.ToInt32(readCommandControlPQ[2]);	// request id bul
							moneyNeeded = _quantity * _price;						// gereken total para 
							firstPriceSelect = false;
						}

						connection.Close();
						connection2 = getConnection();
						connection2.Open();
						try
						{
							command = new MySqlCommand("UPDATE item_user_infos SET quantity = quantity + "  + moneyNeeded + " WHERE item_id = 4 AND user_id= " + destination_user_id, connection2);
							command2 = new MySqlCommand("UPDATE item_user_infos SET quantity = quantity - " + _quantity + " WHERE item_id =" + item_id + " AND user_id= " + destination_user_id, connection2);
							command3 = new MySqlCommand("INSERT INTO source_destination_change_log (request_id, item_id, source_user_id, destination_user_id, order_request_unit_price, order_request_quantity, state_destination, destination_change_date ) VALUES (" + request_id + ", " + item_id + ", " + source_user_id + ", " + destination_user_id + ", " + _price + "," + _quantity + ", 1 ,'" + DateTime.Now.ToString() + "')", connection2);
							//command = new MySqlCommand("UPDATE item_order_request SET state = 1 WHERE request_id ="+request_id+" AND source_user_id ="+source_user_id+" AND destination_user_id = "+destination_user_id+" AND item_id ="+item_id+" AND order_request_unit_price= "+ unitPrice +" AND order_request_quantity ="+quantity , connection2);
							command.ExecuteNonQuery(); command2.ExecuteNonQuery(); command3.ExecuteNonQuery();  // yapilan degisiklikleri database'e kaydettik, istenildigi zaman geri donus islemi yapilabilsin.
							state = true;
						}
						catch (Exception err)
						{
							Console.WriteLine(err.Message);
						}
					}
					catch(Exception err)
                    {
						Console.WriteLine(err.Message);
                    }
					
					
					
				
				}

			}
			catch(Exception err)
            {
				Console.WriteLine(err.Message);
            }
			finally
			{ 
			
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection2.Close();
						//command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}

			return state;
        }

		public bool updateAfterOrderRequestBackUp(int source_user_id, int destination_user_id, int item_id, int quantity, double unitPrice, bool stateType, int request_id) //bool source kismi guncelleme isinin kaynakta mi hedefte mi yapildigini gosteriyor.
		{

			bool state = true;
			double _price=0;
			int _quantity=0;
			double moneyNeeded=0;
			MySqlCommand command = null;
			MySqlCommand command2 = null;
			MySqlCommand commandControlPriceQuantity = null;
			MySqlConnection connection = null;
			try
			{
				connection = getConnection();
				connection.Open();
				if (stateType == false) //kaynakta yapilan degisiklikler geri alinacak.
				{
					try
                    {
						commandControlPriceQuantity = new MySqlCommand("SELECT o.order_request_unit_price, o.order_request_quantity FROM item_user_infos u, item_order_request o, items i WHERE o.state = 0 AND u.selling = 1 AND o.item_id = u.item_id AND o.order_request_unit_price >= u.unit_price AND o.order_request_quantity <= u.quantity GROUP BY u.unit_price", connection);
						MySqlDataReader readCommandControlPQ = commandControlPriceQuantity.ExecuteReader();

						bool firstPriceSelect = true;
						while (readCommandControlPQ.Read() && firstPriceSelect)
						{
							_price = Convert.ToDouble(readCommandControlPQ[0]); // gereken total para icin birim fiyat bul.
							_quantity = Convert.ToInt32(readCommandControlPQ[1]); //						miktar bul
							moneyNeeded = _quantity * _price; //gereken total para 
							firstPriceSelect = false;
						}

						command = new MySqlCommand("UPDATE item_user_infos SET quantity = quantity + " + moneyNeeded + " WHERE item_id = 4 AND user_id= " + source_user_id, connection);
						command.ExecuteNonQuery();
						command2 = new MySqlCommand("UPDATE item_user_infos SET quantity = quantity - " + _quantity + " WHERE item_id =" + item_id + " AND user_id= " + source_user_id, connection);
						command2.ExecuteNonQuery();
						// para iadesi yapildi ve verilen itemler geri alindi.
						state = true;
					}
					catch(Exception err)
                    {
						Console.WriteLine(err.Message);
                    }
					

				}
				else //hedefte yapilan degisiklikler geri alinacak.
				{
					try
                    {
						commandControlPriceQuantity = new MySqlCommand("SELECT o.order_request_unit_price, o.order_request_quantity FROM item_user_infos u, item_order_request o, items i WHERE o.state = 0 AND u.selling = 1 AND o.item_id = u.item_id AND o.order_request_unit_price >= u.unit_price AND o.order_request_quantity <= u.quantity GROUP BY u.unit_price", connection);
						MySqlDataReader readCommandControlPQ = commandControlPriceQuantity.ExecuteReader();

						bool firstPriceSelect = true;
						while (readCommandControlPQ.Read() && firstPriceSelect)
						{
							_price = Convert.ToDouble(readCommandControlPQ[0]); // gereken total para icin birim fiyat bul.
							_quantity = Convert.ToInt32(readCommandControlPQ[1]); //						miktar bul
							moneyNeeded = _quantity * _price; //gereken total para 
							firstPriceSelect = false;
						}

						command = new MySqlCommand("UPDATE item_user_infos SET quantity = quantity - " + moneyNeeded + " WHERE item_id = 4 AND user_id= " + destination_user_id, connection);
						command.ExecuteNonQuery();
						command2 = new MySqlCommand("UPDATE item_user_infos SET quantity = quantity + " + _quantity + " WHERE item_id =" + item_id + " AND user_id= " + destination_user_id, connection);
						command2.ExecuteNonQuery();
						// verilen para geri alindi
						// alinan itemler geri yuklendi.
						state = true;
					}
					catch(Exception err)
                    {
						Console.WriteLine(err.Message);
                    }
				}

			}
			catch (Exception err)
			{
				Console.WriteLine(err.Message);
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}

			return state;
		}

		public bool updateOrderToSell(int sourceID, int itemID, int quantity, int All0, int All1, double unitPrice)
		{
			bool state = false;
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				string sorgum = "";
				if (quantity == All0 && All1 == 0)
				{
					sorgum = "update item_user_infos set selling=1,unit_price='" + unitPrice.ToString().Replace(",", ".") + "' where user_id=" + sourceID + " and item_id=" + itemID;

				}
				else
				{
					if (getId("select id from item_user_infos where selling=1 and (item_id=" + itemID + " and user_id=" + sourceID + ")") != 0)
					{
						int now = getId("select quantity from item_user_infos where selling=1 and (item_id=" + itemID + " and user_id=" + sourceID + ")");
						sorgum = "update item_user_infos set quantity=" + (now + quantity) + ",unit_price=" + unitPrice.ToString().Replace(",", ".") + " where selling=1 and (item_id=" + itemID + " and user_id=" + sourceID + ");";
					}
					else
					{
						sorgum = "insert into item_user_infos (user_id,item_id,quantity,unit_price,selling) values (" + sourceID + "," + itemID + "," + quantity + ",'" + unitPrice.ToString().Replace(",", ".") + "',1);";
					}
					sorgum += "update item_user_infos set quantity=" + (All0 - quantity) + " where selling=0 and (item_id=" + itemID + " and user_id=" + sourceID + ")";
					if (quantity == All0)
					{
						sorgum += ";delete from item_user_infos where selling=0 and (item_id=" + itemID + " and user_id=" + sourceID + ")";
					}
				}
				connection = getConnection();
				connection.Open();
				Random rnd = new Random();
				command = new MySqlCommand(sorgum, connection);
				command.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return state;
		}
		public void manageOrder(int userID, int itemID, int quantity, bitlancer.orderTypes orderType, double unitPriceSell = 0)
		{
			if (orderType == bitlancer.orderTypes.buy)
			{
				int minItemQuantity = getId("select quantity from item_user_infos where unit_price=(select min(unit_price) from item_user_infos where item_id=" + itemID + " and selling=1 and user_id!=" + userID + ") and (item_id=" + itemID + " and selling=1 and user_id!=" + userID + ")");
				int tlITemQuantity = getId("select quantity from item_user_infos where item_id=4 and user_id=" + userID);
				int destItemqQuantity = getId("select quantity from item_user_infos where selling=0 and (item_id=" + itemID + " and user_id=" + userID + ")");
				if (quantity == minItemQuantity)
				{
					int sourceId = getId("select user_id from item_user_infos where unit_price=(select min(unit_price) from item_user_infos where item_id=" + itemID + " and selling=1 and user_id!=" + userID + ") and (item_id=" + itemID + " and selling=1 and user_id!=" + userID + ")");
					int sourceIdTL = getId("select quantity from item_user_infos where item_id=4 and user_id=" + sourceId);
					double unitPrice = getDouble("select unit_price from item_user_infos where selling=1 and (item_id=" + itemID + " and user_id=" + sourceId + ")");
					if (tlITemQuantity >= (quantity * (int)unitPrice))
					{
						setItemOrder(sourceId, userID, itemID, quantity, unitPrice);
						updateAfterOrder(1, sourceId, itemID, 0, unitPrice, true);
						updateAfterOrder(0, userID, itemID, destItemqQuantity + quantity, unitPrice);
						updateAfterOrder(0, userID, 4, tlITemQuantity - (quantity * (int)unitPrice), 1);
						updateAfterOrder(0, sourceId, 4, sourceIdTL + (quantity * (int)unitPrice), 1);
					}
				}
				else
				{
					List<orderUpdateItem> myItems = getItemsById(itemID);
					foreach (orderUpdateItem item in myItems)
					{
						while (quantity != 0)
						{
							int sourceId = getId("select user_id from item_user_infos where unit_price=(select min(unit_price) from item_user_infos where item_id=" + itemID + " and selling=1 and user_id!=" + userID + ") and (item_id=" + itemID + " and selling=1 and user_id!=" + userID + ")");
							if (sourceId != 0)
							{
								int sourceIdTL = getId("select quantity from item_user_infos where item_id=4 and user_id=" + sourceId);
								double unitPrice = getDouble("select unit_price from item_user_infos where selling=1 and (item_id=" + itemID + " and user_id=" + sourceId + ")");
								int miktar = minItemQuantity > quantity ? quantity : minItemQuantity;
								if (tlITemQuantity < (miktar * (int)unitPrice))
								{
									quantity--;
								}
								else
								{
									setItemOrder(sourceId, userID, itemID, miktar, unitPrice);
									if (minItemQuantity <= quantity)
										updateAfterOrder(1, sourceId, itemID, 0, unitPrice, true);
									else
										updateAfterOrder(1, sourceId, itemID, minItemQuantity - miktar, unitPrice);
									updateAfterOrder(0, userID, itemID, destItemqQuantity + miktar, unitPrice);
									updateAfterOrder(0, userID, 4, tlITemQuantity - (miktar * (int)unitPrice), 1);
									updateAfterOrder(0, sourceId, 4, sourceIdTL + (miktar * (int)unitPrice), 1);
									quantity -= miktar;
									destItemqQuantity += miktar;
									minItemQuantity = getId("select quantity from item_user_infos where unit_price=(select min(unit_price) from item_user_infos where item_id=" + itemID + " and selling=1 and user_id!=" + userID + ") and (item_id=" + itemID + " and selling=1 and user_id!=" + userID + ")");
									tlITemQuantity = getId("select quantity from item_user_infos where item_id=4 and user_id=" + userID);
									destItemqQuantity = getId("select quantity from item_user_infos where selling=0 and (item_id=" + itemID + " and user_id=" + userID + ")");
								}
							}
							else
							{
								quantity = 0;
							}
						}
					}
				}
			}
			else
			{
				int myAllQuantity = getId("select quantity from item_user_infos where selling=0 and (item_id=" + itemID + " and user_id=" + userID + ")");
				int myAllQuantity2 = getId("select quantity from item_user_infos where selling=1 and (item_id=" + itemID + " and user_id=" + userID + ")");
				updateOrderToSell(userID, itemID, quantity, myAllQuantity, myAllQuantity2, unitPriceSell);
			}
		}

		public bool manageOrderRequest(int source_user_id,int destination_user_id, int item_id, int order_request_quantity, double order_request_unit_price, int request_id )
        {
			bool siraAtlama = true;
			MySqlConnection connection = null;
			MySqlCommand command = null;
			MySqlCommand commandName = null;
			connection = getConnection();
			try
            {
				bool state1 = updateAfterOrderRequest(source_user_id, destination_user_id, item_id, order_request_quantity, order_request_unit_price, true); //source user money/item change
				bool state2 = updateAfterOrderRequest(source_user_id, destination_user_id, item_id, order_request_quantity, order_request_unit_price, false); //destination user money/item change
				if (!state1 || !state2)
				{
					if(!state1) //kaynakta yapilan degisimlerde hata var demek.
                    {
						siraAtlama = false;
						bool stateBackUp1 = updateAfterOrderRequestBackUp(source_user_id, destination_user_id, item_id, order_request_quantity, order_request_unit_price, false,request_id);
						if(!stateBackUp1)
                        {
							commandName = new MySqlCommand("SELECT user_full_name FROM users WHERE id =" + source_user_id, connection);
							
							MessageBox.Show("Yanlış giden işlemi kurtarma operasyonu basariz oldu. İsteği bırakan kişinin ("+commandName.ExecuteScalar().ToString()+") para/mal miktarları kontrol edilecek.");
                        }
                    }
					else // hedefte yapilan degisimlerde hata var demek.
                    {
						siraAtlama = false;
						bool stateBackUp2 = updateAfterOrderRequestBackUp(source_user_id, destination_user_id, item_id, order_request_quantity, order_request_unit_price, true, request_id);
						if (!stateBackUp2)
						{
							commandName = new MySqlCommand("SELECT user_full_name FROM users WHERE id ="+destination_user_id, connection);
							
							MessageBox.Show("Yanlış giden işlemi kurtarma operasyonu basariz oldu. İsteği temin eden kişinin ("+commandName.ExecuteScalar().ToString()+") para/mal miktarları kontrol edilecek.");
							
						}
					}
				}
				else
				{
					command = new MySqlCommand("UPDATE item_order_request SET destination_user_id =" + destination_user_id + ", state = 1, order_request_finish_date =" + DateTime.Now.ToString() + "WHERE request_id ="+ request_id, connection);
					command.ExecuteNonQuery();
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						if(command!= null)
                        {
							command.Dispose();
						}
						
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return siraAtlama;
		}


		public MySqlCommand refOrderRequest(int _item_id, int _userID, string DesiredPrice, string DesiredQuantity)
        {
			MySqlConnection connection = null;
			MySqlCommand command = null;
			connection = getConnection();
			connection.Open();
			try
            {
				command = new MySqlCommand("INSERT INTO item_order_request (item_id, source_user_id, order_request_unit_price, order_request_quantity, state, order_request_date ) VALUES (@item_id, @source_user_id, @order_request_unit_price, @order_request_quantity, @state, @order_request_date) ", connection);
				command.Parameters.AddWithValue("@item_id", _item_id);
				command.Parameters.AddWithValue("@source_user_id", _userID);
				command.Parameters.AddWithValue("@order_request_unit_price", Convert.ToInt32(DesiredPrice));
				command.Parameters.AddWithValue("order_request_quantity", Convert.ToInt32(DesiredQuantity));
				command.Parameters.AddWithValue("@state", 0);
				command.Parameters.AddWithValue("@order_request_date", DateTime.Now.ToString());
				command.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return command;
		}

		public void orderRequestCheck()
        {
			MySqlCommand command = null;
			MySqlConnection connection = null;
			connection = getConnection();
			connection.Open();
			try
            {
				bool siraAtla = false;
				command = new MySqlCommand("SELECT o.source_user_id as 'Kaynak ID', u.user_id as 'Hedef ID ',(select item_name from items where id=u.item_id) as 'item', u.item_id as 'item id', o.order_request_unit_price as 'istek fiyatı', o.order_request_quantity as 'istek miktari', u.unit_price as 'Hedef Fiyati', u.quantity as 'hedef miktari', o.request_id  FROM item_user_infos u, item_order_request o WHERE ((o.state = 0 AND u.selling = 1) AND (o.item_id = u.item_id AND o.order_request_unit_price >= u.unit_price)) AND o.order_request_quantity <= u.quantity GROUP BY u.unit_price", connection);
				MySqlDataReader readCommand = command.ExecuteReader();
				while (readCommand.Read() == true && siraAtla == false)
                {
					siraAtla = manageOrderRequest(Convert.ToInt32(readCommand[0]), Convert.ToInt32(readCommand[1]), Convert.ToInt32(readCommand[3]), Convert.ToInt32(readCommand[5]), Convert.ToDouble(readCommand[4]), Convert.ToInt32(readCommand[6]));
					
                }

			}
			catch (Exception err)
            {
				Console.WriteLine(err.Message);
            }
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			
		}

		public DataTable setOrderRequestDataTable()
        {
			MySqlDataAdapter adtr = null;
			MySqlConnection connection = null;
			connection = getConnection();
			connection.Open();
			DataTable dtbl = new DataTable();
			try
            {
				adtr = new MySqlDataAdapter("SELECT * FROM item_order_request WHERE state = 0", connection);
				adtr.Fill(dtbl);

			}
			catch(Exception err)
            {
				Console.WriteLine(err.Message);
            }
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						adtr.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return dtbl;
        }

		public DataTable setOrderRequestHistoryDataTable()
        {
			MySqlDataAdapter adtr = null;
			MySqlConnection connection = null;
			connection = getConnection();
			connection.Open();
			DataTable dtbl = new DataTable();
			try
			{
				adtr = new MySqlDataAdapter("SELECT * FROM item_order_request WHERE state = 1", connection);
				adtr.Fill(dtbl);

			}
			catch (Exception err)
			{
				Console.WriteLine(err.Message);
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						adtr.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return dtbl;
		}
		public List<orderUpdateItem> getItemsById(int itemID)
		{
			List<orderUpdateItem> items = new List<orderUpdateItem>();
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				connection = getConnection();
				connection.Open();
				command = new MySqlCommand("select user_id,quantity,unit_price from item_user_infos where item_id=" + itemID, connection);
				MySqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					orderUpdateItem myItem = new orderUpdateItem();
					myItem.id = itemID;
					myItem.sourceId = int.Parse(reader[0].ToString());
					myItem.unitPrice = Convert.ToDouble(reader[2]);
					myItem.quantity = int.Parse(reader[1].ToString());
					items.Add(myItem);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return items;
		}
		public bool updateUser(int id, string userName, string fullName, string password, string tel, string mail, string address)
		{
			bool state = false;
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				connection = getConnection();
				connection.Open();
				command = new MySqlCommand("update users set user_name='" + userName + "', user_full_name='" + fullName + "', user_password='" + password + "', user_tel='" + tel + "', user_mail='" + mail + "', user_address='" + address + "' where id=" + id, connection);
				command.ExecuteNonQuery();
				state = true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				state = false;
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return state;
		}
		public void uptadeAdminOnayDataGrid(int id, int state, string description,double unit_price)
		{
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				connection = getConnection();
				connection.Open();
				Random rnd = new Random();
				command = new MySqlCommand("update item_adds set state =" + state + ", description ='" + description + "' where id=" + id, connection);
				command.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
		}
		public DataTable GetTable(string sql)
		{
			DataTable dt = new DataTable();
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				connection = getConnection();
				connection.Open();
				command = new MySqlCommand(sql, connection);
				dt.Load(command.ExecuteReader());
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return dt;
		}
		public bool userRegister(string userFullName, string userName, string userPassword, string userAddres, string userMail, string userTc, string userTel)
		{
			bool state = false;
			MySqlConnection connection = null;
			MySqlCommand command = null;
			try
			{
				connection = getConnection();
				connection.Open();
				command = new MySqlCommand("insert into users(user_full_name,user_name,user_password,user_address,user_mail,user_tc,user_tel,user_type_id) values ('" + userFullName + "','" + userName + "','" + userPassword + "','" + userAddres + "','" + userMail + "','" + userTc + "','" + userTel + "','" + 6 + "')", connection);
				command.ExecuteNonQuery();
				state = true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				state = false;
			}
			finally
			{
				if (connection != null)
				{
					try
					{//bağlantıları kapat
						connection.Close();
						command.Dispose();
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}
			return state;
		}
	}
}