﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using Files.Application.Board;
using File.Domain.Board;

namespace File.Contract
{
    public class BoardApplication : IBoardApplication
    {
        private readonly IBoardRepository _boardRepository;

        public BoardApplication(IBoardRepository boardRepository)
        {
            _boardRepository = boardRepository;
        }

        public OperationResult Create(CreateBoard command)
        {
            var operation = new OperationResult();

            var disputeResolutionPetitionDate = new DateTime();

            disputeResolutionPetitionDate = command.DisputeResolutionPetitionDate.ToGeorgianDateTime();
            //TODO if
            //if(_BoardRepository.Exists(x=>x.Branch == command.Branch))
            //    operation.Failed("fail message")

            var board = new Board(disputeResolutionPetitionDate, command.Branch, command.BoardChairman,
                command.ExpertReport,command.File_Id, command.BoardType_Id);
            _boardRepository.Create(board);
            _boardRepository.SaveChanges();

            return operation.Succcedded(board.Id);
        }

        public OperationResult Edit(EditBoard command)
        {
            var operation = new OperationResult();
            var board = _boardRepository.Get(command.Id);

            var disputeResolutionPetitionDate = new DateTime();
            disputeResolutionPetitionDate = command.DisputeResolutionPetitionDate.ToGeorgianDateTime();

            //TODO
            //if(_BoardRepository.Exists(x=>x.Branch == command.Branch))
            //    operation.Failed("fail message")

            board.Edit(disputeResolutionPetitionDate, command.Branch, command.BoardChairman,
                command.ExpertReport,command.File_Id,command.BoardType_Id);
            _boardRepository.SaveChanges();

            return operation.Succcedded(board.Id);
        }

        public EditBoard GetDetails(long id)
        {
            return _boardRepository.GetDetails(id);
        }

        public EditBoard GetDetails(long fileId, int boardTypeId)
        {
            return _boardRepository.GetDetails(fileId, boardTypeId);
        }

        public List<BoardViewModel> Search(BoardSearchModel searchModel)
        {
            return _boardRepository.Search(searchModel);
        }
    }
}
