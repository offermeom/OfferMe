using Moq;
using API.Models;
using API.Interfaces;
using API.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using API.Exceptions;

namespace API.Tests;
// TODO: Test Coverage
[TestFixture]
public class UserControllerTests
{
    private static string? Number;
    private static string? Password;
    private UserController _UserController;
    private Mock<IUserService> _MockIUserService;
    private Mock<ILogger<UserController>> _MockIlogger;
    [SetUp]
    public void Setup()
    {
        _MockIlogger = new Mock<ILogger<UserController>>();
        _MockIUserService = new Mock<IUserService>();
        _UserController = new UserController(_MockIUserService.Object, _MockIlogger.Object);
    }
    [Test] // ** Passed
    public void SignIn406()
    {
        Number = "0123456789";
        Password = "prasad";
        _MockIUserService.Setup(u => u.Get(Number, Password)).Throws(new InvalidUserException());
        var result = _UserController.SignIn(Number, Password) as StatusCodeResult;
        Assert.That(result!.StatusCode, Is.EqualTo(StatusCodes.Status406NotAcceptable));
    }
    [Test] // ** Passed
    public void SignIn202()
    {
        Number = "8428558275";
        Password = "prasad";
        _MockIUserService.Setup(u => u.Get(Number, Password)).Returns(new User());
        var result = _UserController.SignIn(Number, Password) as StatusCodeResult;
        Assert.That(result!.StatusCode, Is.EqualTo(StatusCodes.Status202Accepted));
    }
    /*
    [Test] // ** Passed
    public async Task SignUp403()
    {
        User user = new()
        {
            Name = "Prasad",
            Number = "8428558275",
            Mail = "naren000000000@gmail.com",
            Password = "prasad",
            GSTIN = "0A1B2C3D4E5F6G7"
        };
        _MockIUserService.Setup(u => u.Post(user)).Throws(new DuplicateUserException());
        var result = await _UserController.SignUp(user);
        Assert.That((result as StatusCodeResult)!.StatusCode, Is.EqualTo(StatusCodes.Status403Forbidden));
    }
    */
    /*
    [Test] // ** Passed
    public async Task SignUp201()
    {
        User user = new()
        {
            Name = "SRNP",
            Number = "9876543210",
            Mail = "pmpsrnp@outlook.com",
            Password = "srnp",
            GSTIN = "7G6F5E4D3C2B1A0"
        };
        _MockIUserService?.Setup(u => u.Post(user));
        var result = await _UserController.SignUp(user);
        Assert.That((result as StatusCodeResult)!.StatusCode, Is.EqualTo(StatusCodes.Status201Created));
    }
    */
}