﻿using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Tgstation.Server.Api.Models.Internal;

namespace Tgstation.Server.Host.Components
{
	/// <summary>
	/// For managing connected chat services
	/// </summary>
	interface IChat : IHostedService
	{
		/// <summary>
		/// If the IRC client is connected
		/// </summary>
		bool IrcConnected { get; }

		/// <summary>
		/// If the Discord client is connected
		/// </summary>
		bool DiscordConnected { get; }

		/// <summary>
		/// Change chat settings
		/// </summary>
		/// <param name="newSettings">The new <see cref="ChatSettings"/></param>
		/// <param name="cancellationToken">The <see cref="CancellationToken"/> for the operation</param>
		/// <returns>A <see cref="Task"/> representing the running operation</returns>
		Task ChangeSettings(ChatSettings newSettings, CancellationToken cancellationToken);

		/// <summary>
		/// Change chat channels
		/// </summary>
		/// <param name="newChannels">An <see cref="IEnumerable{T}"/> of the new list of <see cref="Api.Models.ChatChannel"/>s</param>
		/// <param name="cancellationToken">The <see cref="CancellationToken"/> for the operation</param>
		/// <returns>A <see cref="Task"/> representing the running operation</returns>
		Task ChangeChannels(IEnumerable<Api.Models.ChatChannel> newChannels, CancellationToken cancellationToken);

		/// <summary>
		/// Send a chat <paramref name="message"/> to a given set of <paramref name="channelIds"/>
		/// </summary>
		/// <param name="message">The message being sent</param>
		/// <param name="channelIds">The <see cref="Models.ChatChannel.Id"/>s of the <see cref="Models.ChatChannel"/>s to send to</param>
		/// <param name="cancellationToken">The <see cref="CancellationToken"/> for the operation</param>
		/// <returns>A <see cref="Task"/> representing the running operation</returns>
		Task SendMessage(string message, IEnumerable<long> channelIds, CancellationToken cancellationToken);
	}
}