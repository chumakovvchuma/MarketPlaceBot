﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTelegramBot.BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace MyTelegramBot.BusinessLayer
{
    public class FeedbackFunction
    {
        public static FeedBack EnableFeedback(int FeedBackId)
        {
            MarketBotDbContext db = new MarketBotDbContext();

            try
            {
                var feedback = db.FeedBack.Find(FeedBackId);
                feedback.DateAdd = DateTime.Now;
                feedback.Enable = true;
                db.Update<FeedBack>(feedback);
                db.SaveChanges();
                return feedback;
            }
            catch
            {
                return null;
            }

            finally
            {
                db.Dispose();
            }
        }

        public static FeedBack InsertFeedBack(int Raiting, int ProductId, int OrderId)
        {
            MarketBotDbContext db = new MarketBotDbContext();

            try
            {
                FeedBack feedBack = new FeedBack
                {
                    OrderId = OrderId,
                    ProductId = ProductId,
                    RaitingValue = Raiting,
                    Enable = false
                };

                db.FeedBack.Add(feedBack);
                db.SaveChanges();
                return feedBack;
            }

            catch
            {
                return null;
            }

            finally
            {
                db.Dispose();
            }
        }

        public static FeedBack GetFeedBack(int Id)
        {
            MarketBotDbContext db = new MarketBotDbContext();

            try
            {
                return db.FeedBack.Where(f => f.Id == Id).Include(f => f.Product).FirstOrDefault();

            }

            catch
            {
                return null;
            }

            finally
            {
                db.Dispose();
            }
        }

        public static int RemoveFeedBack(int Id)
        {
            MarketBotDbContext db = new MarketBotDbContext();

            try
            {
                var feedback= db.FeedBack.Find(Id);

                db.FeedBack.Remove(feedback);

                return db.SaveChanges();

            }

            catch
            {
                return -1;
            }

            finally
            {
                db.Dispose();
            }
        }
    }
}
