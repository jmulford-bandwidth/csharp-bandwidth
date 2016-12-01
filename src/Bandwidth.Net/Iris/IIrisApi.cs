﻿namespace Bandwidth.Net.Iris
{
  /// <summary>
  ///   Iris Api interface
  /// </summary>
  public interface IIrisApi
  {
    /// <summary>
    /// Access to Account Api
    /// </summary>
    IAccount Account { get;}

    /// <summary>
    /// Access to AvailableNpaNxx Api
    /// </summary>
    IAvailableNpaNxx AvailableNpaNxx { get; }

    /// <summary>
    /// Access to AvailableNumber Api
    /// </summary>
    IAvailableNumber AvailableNumber { get;}

    /// <summary>
    /// Access to City Api
    /// </summary>
    ICity City { get; }

  }

  /// <summary>
  ///   Auth data for Iris Api
  /// </summary>
  public class IrisAuthData
  {
        /// <summary>
    ///   Account ID
    /// </summary>
    public string AccountId { get; set; }

    /// <summary>
    ///   User Name
    /// </summary>
    public string UserName { get; set; }

    /// <summary>
    ///   Password
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    ///   Optional base url of iris services
    /// </summary>
    public string BaseUrl { get; set; } = "https://api.inetwork.com/v1.0";
  }
}