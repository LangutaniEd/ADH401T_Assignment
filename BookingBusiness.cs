using System;
using System.Linq;
using System.Web;
using KFP.DATA;
using System.Collections.Generic;

namespace KFP.BUSINESS
{
    public class BookingBusiness
    {
      //  KFG_Db storeDB = new KFG_Db();
      //  UnitOfWork unitofwork = new UnitOfWork();

      //  public string BookingClassId { get; set; }
      //  public const string BookingSessionKey = "BookingNo";
      //  public static BookingBusiness GetBooking(HttpContextBase context)
      //  {
      //      var book = new BookingBusiness();
      //      book.BookingClassId = book.GetBookingId(context);
      //      return book;
      //  }
      //  private string GetBookingId(HttpContextBase context)
      //  {
      //      if (HttpContext.Current.Session[BookingSessionKey] == null)
      //      {
      //          if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
      //          {
      //              HttpContext.Current.Session[BookingSessionKey] = HttpContext.Current.User.Identity.Name;
      //          }
      //          else
      //          {
      //              // Generate a new random GUID using System.Guid class.     
      //              Guid tempCartId = Guid.NewGuid();
      //              HttpContext.Current.Session[BookingSessionKey] = tempCartId.ToString();
      //          }
      //      }
      //      return HttpContext.Current.Session[BookingSessionKey].ToString();
      //  }
      //  public void CreateBooking(Klass Klass)
      //  {

      //      KFG_Db storeDB = new KFG_Db();
      //      // Get the matching cart and album instances
      //      var BookingItem = storeDB.Booking.SingleOrDefault(
      //          c => c.bookingNO == BookingClassId
      //          && c.KlassId == Klass.KlassId);
      //      using (var bookingrip = new UnitOfWork())
      //      {
      //          UnitOfWork unitofwork = new UnitOfWork();
      //      if (BookingItem == null)
      //      {
      //              // Create a new cart item if no cart item exists
      //              BookingItem = new Booking
      //              {
      //               KlassId = Klass.KlassId,
      //              bookingNO = BookingClassId,
      //              CreatedTime = DateTime.Now,
      //              Size = Klass.Size,
      //              Time_in = Klass.Time_in,
      //              Time_Out = Klass.Time_Out,
                    
      //          };
      //          //storeDB.Booking.Add(BookingItem);
      //          //storeDB.SaveChanges();
      //              unitofwork.bookingRepositorys.Insert(BookingItem);
      //              unitofwork.Save();
      //          }
      //    }
      //}
        
      //  public void GetClassDetails(int? id)
      //  {
      //      KFG_Db storeDB = new KFG_Db();
      //      UnitOfWork unitofwork = new UnitOfWork();
      //      var klss = from c in storeDB.Klass
      //                 from b in storeDB.Booking
      //                 where c.KlassId == b.KlassId
      //                 select c.KlassId;

      //      Klass klass = unitofwork.KlassRepositorys.SelectByID(id);
      //  }
      //  public List<Booking> GetBookingItems()
      //  {
      //      using (var bookingrip = new UnitOfWork())
      //      {
      //          return bookingrip.bookingRepositorys.Get().Where(Booking => Booking.bookingNO == BookingClassId).ToList();
      //      }
      //  }
        //public int RemoveFromBooking(int id)
        //{
        //    // Get the cart
        //    var s = storeDB.Booking.ToList().Find(x => x.RecordId == id);
        //    var cartItems = storeDB.Booking.Single(
        //        booking => booking.bookingNO == BookingClassId
        //        && booking.RecordId == id);
        //    using (var bookingrip = new UnitOfWork())
        //    {
        //        int itemCount = 0;
        //        if (cartItems != null)
        //        {
        //            if (cartItems.Count > 1)
        //            {
        //                cartItems.Count--;
        //                itemCount = cartItems.Count;
        //            }
        //            else
        //            {
        //                bookingrip.bookingRepositorys.Delete(cartItems);
        //            }
        //            bookingrip.Save();
        //        }
        //        return itemCount;
        //    }
        //}
    }
}
