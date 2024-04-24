﻿using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void Delete(Room t)
        {
            _roomDal.Delete(t);
        }

        public Room GetById(Guid id)
        {
            return _roomDal.GetById(id);
        }

        public List<Room> GetList()
        {
            return _roomDal.GetList();
        }

        public void Insert(Room t)
        {
            _roomDal.Insert(t);
        }

        public int RoomCount()
        {
            return _roomDal.RoomCount();
        }

        public void Update(Room t)
        {
            _roomDal.Update(t);
        }
    }
}

