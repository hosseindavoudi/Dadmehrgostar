﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using File.Domain.ProceedingSession;
using Files.Application.File;
using Files.Application.ProceedingSession;

namespace File.Contract
{
    public class ProceedingSessionApplication : IProceedingSessionApplication
    {
        private readonly IProceedingSessionRepository _proceedingSessionRepository;

        public ProceedingSessionApplication(IProceedingSessionRepository proceedingSessionRepository)
        {
            _proceedingSessionRepository = proceedingSessionRepository;
        }

        public OperationResult Create(CreateProceedingSession command)
        {
            var operation = new OperationResult();

            var Date = new DateTime();
            Date = command.Date.ToGeorgianDateTime();

            //var Time = new DateTime();
            //Time = command.Time.ToGeorgianDateTime();

            //TODO if
            //if (_BoardRepository.Exists(x => x.Branch == command.Branch))
            //        operation.Failed("fail message")

            var proSession = new ProceedingSession(Date, command.Time, command.Board_Id);
            _proceedingSessionRepository.Create(proSession);
            _proceedingSessionRepository.SaveChanges();

            return operation.Succcedded();
        }

        public OperationResult CreateProceedingSessions(List<EditProceedingSession> proceedingSessions, long boardId)
        {
            var operation = new OperationResult();

            RemoveProceedingSessions(boardId);

            foreach (var obj in proceedingSessions)
            {
                obj.Board_Id = boardId;
                obj.Id = 0;

                Create(obj);
            }

            return operation.Succcedded();
        }

        public OperationResult Edit(EditProceedingSession command)
        {
            var operation = new OperationResult();
            var proSession = _proceedingSessionRepository.Get(command.Id);

            //var Date = new DateTime();
            //Date = command.Date.ToGeorgian();

            //var Time = new DateTime();
            //Time = command.Time.ToGeorgian();

            //TODO
            //if(_BoardRepository.Exists(x=>x.Branch == command.Branch))
            //    operation.Failed("fail message")

            //proSession.Edit(Date,Time,command.Board_Id);
            //_proceedingSessionRepository.SaveChanges();

            return operation.Succcedded();
        }

        public void RemoveProceedingSessions(long boardId)
        {
            var objects = Search(boardId);

            _proceedingSessionRepository.RemoveProceedingSessions(objects);
        }

        public List<EditProceedingSession> Search(long boardId)
        {
            return _proceedingSessionRepository.Search(boardId);
        }
    }
}
