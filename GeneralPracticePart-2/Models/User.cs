using GeneralPracticePart_2.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralPracticePart_2.Models
{
    internal class User
    {
        public int Id { get;}
        private static int _id;
        List<Status> statuses;
      

        public string UserName { get; set; }
        public User(string username)
        {
            _id++;
            Id = _id;
            UserName=username;
            statuses = new List<Status>();
        }

      

        public void ShareStatus(Status status)
        {
            if (status == null)
                throw new NullReferenceException("null ola bilmez");
            statuses.Add(status);
            return;

            throw new CapacityLimitException("Limit doldu!");
        }


        public List<Status> GetAllStatuses()
        {

            {
                List<Status> statues1 = new List<Status>();
                statues1.AddRange(statuses);

                return statues1;
            }



        }
        public Status GetStatusById(int? id)
        {
            if (id == null)
            {
                throw new NotFoundException("bu idli status yoxdur!");
            }

            if (statuses.Exists(s => s.Id == id))
            {
                Status status= statuses.Find(s => s.Id == id);

                return status;
            }

            throw new CapacityLimitException("Limit doldu!");
        }

        public List<Status> FilterStatusByDate(int? id,DateTime date)
        {
            List<Status> status1 = new List<Status>();

            if (id == null || date == null)
            {
                throw new NotFoundException("Bu idli status yoxdur!");
            }

            if (statuses.Exists(s => s.SharedDate > date) && User._id == id)
            {
                status1 = statuses.FindAll(s => s.Id == id && s.SharedDate < date);
                return status1;
            }

            throw new NotFoundException("Bu idli status yoxdur!");
        }
    }
}
