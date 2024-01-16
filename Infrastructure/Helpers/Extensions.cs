
namespace BCM.Infrastructure.Helpers
{
	public static class Extensions
	{
		public static string FormatTimeAgo(DateTime pastTime)
		{
			TimeSpan timeDifference = DateTime.Now - pastTime;

			if (timeDifference.TotalMinutes < 1)
			{
				return "Just now";
			}
			else if (timeDifference.TotalMinutes < 60)
			{
				int minutesAgo = (int)timeDifference.TotalMinutes;
				return minutesAgo + (minutesAgo == 1 ? " min ago" : " mins ago");
			}
			else if (timeDifference.TotalHours < 24)
			{
				int hoursAgo = (int)timeDifference.TotalHours;
				return hoursAgo + (hoursAgo == 1 ? " hour ago" : " hours ago");
			}
			else if (timeDifference.TotalDays < 2)
			{
				return "Yesterday";
			}
			else
			{
				int daysAgo = (int)timeDifference.TotalDays;
				return daysAgo + (daysAgo == 1 ? " day ago" : " days ago");
			}
		}

		public static string GetDashes(int level)
		{
			if (level == 1)
				return "";

			return GetDashes(--level) + "-";
		}

		public static string GetSpaces(int level)
		{
			if (level == 1)
				return "";

			return GetSpaces(--level) + "&nbsp;&nbsp;&nbsp;";
		}

		public static bool IsListNullOrEmpty<T>(this ICollection<T>? list)
		{
			return list is null || list.Count == 0;
		}

        public static bool IsListNullOrEmpty<T>(this IEnumerable<T>? list)
        {
			return list is null || list.Count() == 0;
        }

        public static bool IsOfferActive(DateTime? start, DateTime? end)
        {
			if ((DateTime.Now > start && DateTime.Now < end)
				|| (DateTime.Now > start && end == null)
				|| (DateTime.Now < end && start == null)
				|| (end == null && start == null))
				return true;

			return false;
        }



    }
}

