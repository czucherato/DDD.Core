using Moq;
using Xunit;
using System;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using DDD.Core.Common.Mediator;
using DDD.Core.Common.Messages;
using FluentValidation.Results;

namespace DDD.Core.Common.Tests.Mediator
{
    public class MediatorHandlerTests
    {
        [Fact]
        public async Task MediatorHandler_Publish_Event()
        {
            //Arrange
            var @event = new ExternalEvent();
            var mediatorMock = new Mock<IMediator>();
            var mediatorHandler = new MediatorHandler(mediatorMock.Object);

            //Act
            await mediatorHandler.Publish(@event);

            //Assert
            mediatorMock.Verify(x => x.Publish(@event, CancellationToken.None), Times.Once);
        }

        [Fact]
        public async Task MediatorHandler_Send_Query()
        {
            //Arrange
            var query = new ResultQuery();
            var mediatorMock = new Mock<IMediator>();
            mediatorMock.Setup(x => x.Send(It.IsAny<Query<Result>>(), CancellationToken.None)).Returns(Task.FromResult(new Result()));
            var mediatorHandler = new MediatorHandler(mediatorMock.Object);

            //Act
            var result = await mediatorHandler.Query<ResultQuery, Result>(query);

            //Assert
            mediatorMock.Verify(x => x.Send(query, CancellationToken.None), Times.Once);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task MediatorHandler_Send_Command()
        {
            //Arrange
            var command = new ActionCommand();
            var mediatorMock = new Mock<IMediator>();
            mediatorMock.Setup(x => x.Send(It.IsAny<Command<ValidationResult>>(), CancellationToken.None)).Returns(Task.FromResult(new ValidationResult()));
            var mediatorHandler = new MediatorHandler(mediatorMock.Object);

            //Act
            var result = await mediatorHandler.Send<ActionCommand, ValidationResult>(command);

            //Assert
            mediatorMock.Verify(x => x.Send(command, CancellationToken.None), Times.Once);
            Assert.NotNull(result);

        }
    }

    public class Result { }

    public class ExternalEvent : Event { }

    public class ResultQuery : Query<Result> { }

    public class ActionCommand : Command<ValidationResult>
    {
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}