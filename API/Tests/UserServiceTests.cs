/*using System;
using Moq;
using API.Data;
using API.Models;
using API.Services;
using API.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
namespace API.Tests;
[TestFixture]
public class UserServiceTests
{
    private static Mock<OMContext> _MockOMContext;
    private static IUserService _IUserService;
    private static Mock<ILogger<UserService>> _MockIlogger;
    [SetUp]
    public void Setup()
    {
        _MockOMContext = new Mock<OMContext>();
        _MockIlogger = new Mock<ILogger<UserService>>();
        _IUserService = new UserService(_MockIlogger.Object, _MockOMContext.Object);
    }
    [TearDown]
    public void Cleanup()
    {
        _MockIlogger.Reset();
        _MockOMContext.Reset();
        _IUserService = null;
    }
}
*/