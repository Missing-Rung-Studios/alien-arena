// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Leaderboards
{
	/// <summary>
	/// Contains information about a single leaderboard user score
	/// </summary>
	public class LeaderboardUserScore : ISettable
	{
		/// <summary>
		/// The Product User ID of the user who got this score
		/// </summary>
		public ProductUserId UserId { get; set; }

		/// <summary>
		/// Leaderboard score
		/// </summary>
		public int Score { get; set; }

		internal void Set(LeaderboardUserScoreInternal? other)
		{
			if (other != null)
			{
				UserId = other.Value.UserId;
				Score = other.Value.Score;
			}
		}

		public void Set(object other)
		{
			Set(other as LeaderboardUserScoreInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct LeaderboardUserScoreInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_UserId;
		private int m_Score;

		public ProductUserId UserId
		{
			get
			{
				ProductUserId value;
				Helper.TryMarshalGet(m_UserId, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_UserId, value);
			}
		}

		public int Score
		{
			get
			{
				return m_Score;
			}

			set
			{
				m_Score = value;
			}
		}

		public void Set(LeaderboardUserScore other)
		{
			if (other != null)
			{
				m_ApiVersion = LeaderboardsInterface.LeaderboarduserscoreApiLatest;
				UserId = other.UserId;
				Score = other.Score;
			}
		}

		public void Set(object other)
		{
			Set(other as LeaderboardUserScore);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_UserId);
		}
	}
}