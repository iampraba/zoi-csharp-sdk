using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class PlanDetails : Model, ResponseHandler
	{
		private long? usageLimit;
		private string apikeyGeneratedTime;
		private long? remainingUsageLimit;
		private long? lastPaymentDateMs;
		private long? nextPaymentDateMs;
		private string lastPaymentDate;
		private long? apikeyId;
		private string planName;
		private long? apikeyGeneratedTimeMs;
		private string paymentLink;
		private string nextPaymentDate;
		private string subscriptionInterval;
		private long? totalUsage;
		private string subscriptionPeriod;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public long? UsageLimit
		{
			/// <summary>The method to get the usageLimit</summary>
			/// <returns>long? representing the usageLimit</returns>
			get
			{
				return  this.usageLimit;

			}
			/// <summary>The method to set the value to usageLimit</summary>
			/// <param name="usageLimit">long?</param>
			set
			{
				 this.usageLimit=value;

				 this.keyModified["usage_limit"] = 1;

			}
		}

		public string ApikeyGeneratedTime
		{
			/// <summary>The method to get the apikeyGeneratedTime</summary>
			/// <returns>string representing the apikeyGeneratedTime</returns>
			get
			{
				return  this.apikeyGeneratedTime;

			}
			/// <summary>The method to set the value to apikeyGeneratedTime</summary>
			/// <param name="apikeyGeneratedTime">string</param>
			set
			{
				 this.apikeyGeneratedTime=value;

				 this.keyModified["apikey_generated_time"] = 1;

			}
		}

		public long? RemainingUsageLimit
		{
			/// <summary>The method to get the remainingUsageLimit</summary>
			/// <returns>long? representing the remainingUsageLimit</returns>
			get
			{
				return  this.remainingUsageLimit;

			}
			/// <summary>The method to set the value to remainingUsageLimit</summary>
			/// <param name="remainingUsageLimit">long?</param>
			set
			{
				 this.remainingUsageLimit=value;

				 this.keyModified["remaining_usage_limit"] = 1;

			}
		}

		public long? LastPaymentDateMs
		{
			/// <summary>The method to get the lastPaymentDateMs</summary>
			/// <returns>long? representing the lastPaymentDateMs</returns>
			get
			{
				return  this.lastPaymentDateMs;

			}
			/// <summary>The method to set the value to lastPaymentDateMs</summary>
			/// <param name="lastPaymentDateMs">long?</param>
			set
			{
				 this.lastPaymentDateMs=value;

				 this.keyModified["last_payment_date_ms"] = 1;

			}
		}

		public long? NextPaymentDateMs
		{
			/// <summary>The method to get the nextPaymentDateMs</summary>
			/// <returns>long? representing the nextPaymentDateMs</returns>
			get
			{
				return  this.nextPaymentDateMs;

			}
			/// <summary>The method to set the value to nextPaymentDateMs</summary>
			/// <param name="nextPaymentDateMs">long?</param>
			set
			{
				 this.nextPaymentDateMs=value;

				 this.keyModified["next_payment_date_ms"] = 1;

			}
		}

		public string LastPaymentDate
		{
			/// <summary>The method to get the lastPaymentDate</summary>
			/// <returns>string representing the lastPaymentDate</returns>
			get
			{
				return  this.lastPaymentDate;

			}
			/// <summary>The method to set the value to lastPaymentDate</summary>
			/// <param name="lastPaymentDate">string</param>
			set
			{
				 this.lastPaymentDate=value;

				 this.keyModified["last_payment_date"] = 1;

			}
		}

		public long? ApikeyId
		{
			/// <summary>The method to get the apikeyId</summary>
			/// <returns>long? representing the apikeyId</returns>
			get
			{
				return  this.apikeyId;

			}
			/// <summary>The method to set the value to apikeyId</summary>
			/// <param name="apikeyId">long?</param>
			set
			{
				 this.apikeyId=value;

				 this.keyModified["apikey_id"] = 1;

			}
		}

		public string PlanName
		{
			/// <summary>The method to get the planName</summary>
			/// <returns>string representing the planName</returns>
			get
			{
				return  this.planName;

			}
			/// <summary>The method to set the value to planName</summary>
			/// <param name="planName">string</param>
			set
			{
				 this.planName=value;

				 this.keyModified["plan_name"] = 1;

			}
		}

		public long? ApikeyGeneratedTimeMs
		{
			/// <summary>The method to get the apikeyGeneratedTimeMs</summary>
			/// <returns>long? representing the apikeyGeneratedTimeMs</returns>
			get
			{
				return  this.apikeyGeneratedTimeMs;

			}
			/// <summary>The method to set the value to apikeyGeneratedTimeMs</summary>
			/// <param name="apikeyGeneratedTimeMs">long?</param>
			set
			{
				 this.apikeyGeneratedTimeMs=value;

				 this.keyModified["apikey_generated_time_ms"] = 1;

			}
		}

		public string PaymentLink
		{
			/// <summary>The method to get the paymentLink</summary>
			/// <returns>string representing the paymentLink</returns>
			get
			{
				return  this.paymentLink;

			}
			/// <summary>The method to set the value to paymentLink</summary>
			/// <param name="paymentLink">string</param>
			set
			{
				 this.paymentLink=value;

				 this.keyModified["payment_link"] = 1;

			}
		}

		public string NextPaymentDate
		{
			/// <summary>The method to get the nextPaymentDate</summary>
			/// <returns>string representing the nextPaymentDate</returns>
			get
			{
				return  this.nextPaymentDate;

			}
			/// <summary>The method to set the value to nextPaymentDate</summary>
			/// <param name="nextPaymentDate">string</param>
			set
			{
				 this.nextPaymentDate=value;

				 this.keyModified["next_payment_date"] = 1;

			}
		}

		public string SubscriptionInterval
		{
			/// <summary>The method to get the subscriptionInterval</summary>
			/// <returns>string representing the subscriptionInterval</returns>
			get
			{
				return  this.subscriptionInterval;

			}
			/// <summary>The method to set the value to subscriptionInterval</summary>
			/// <param name="subscriptionInterval">string</param>
			set
			{
				 this.subscriptionInterval=value;

				 this.keyModified["subscription_interval"] = 1;

			}
		}

		public long? TotalUsage
		{
			/// <summary>The method to get the totalUsage</summary>
			/// <returns>long? representing the totalUsage</returns>
			get
			{
				return  this.totalUsage;

			}
			/// <summary>The method to set the value to totalUsage</summary>
			/// <param name="totalUsage">long?</param>
			set
			{
				 this.totalUsage=value;

				 this.keyModified["total_usage"] = 1;

			}
		}

		public string SubscriptionPeriod
		{
			/// <summary>The method to get the subscriptionPeriod</summary>
			/// <returns>string representing the subscriptionPeriod</returns>
			get
			{
				return  this.subscriptionPeriod;

			}
			/// <summary>The method to set the value to subscriptionPeriod</summary>
			/// <param name="subscriptionPeriod">string</param>
			set
			{
				 this.subscriptionPeriod=value;

				 this.keyModified["subscription_period"] = 1;

			}
		}

		/// <summary>The method to check if the user has modified the given key</summary>
		/// <param name="key">string</param>
		/// <returns>int? representing the modification</returns>
		public int? IsKeyModified(string key)
		{
			if((( this.keyModified.ContainsKey(key))))
			{
				return  this.keyModified[key];

			}
			return null;


		}

		/// <summary>The method to mark the given key as modified</summary>
		/// <param name="key">string</param>
		/// <param name="modification">int?</param>
		public void SetKeyModified(string key, int? modification)
		{
			 this.keyModified[key] = modification;


		}


	}
}