using Com.Zoho.Exception;
using Com.Zoho.Util;

namespace Com.Zoho.Officeintegrator.V1
{

	public class V1Operations
	{
		/// <summary>The method to create document</summary>
		/// <param name="request">Instance of CreateDocumentParameters</param>
		/// <returns>Instance of APIResponse<WriterResponseHandler></returns>
		public APIResponse<WriterResponseHandler> CreateDocument(CreateDocumentParameters request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/writer/officeapi/v1/documents");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.ContentType="multipart/form-data";

			handlerInstance.Request=request;

			return handlerInstance.APICall<WriterResponseHandler>(typeof(WriterResponseHandler), "application/json");


		}

		/// <summary>The method to create document preview</summary>
		/// <param name="request">Instance of PreviewParameters</param>
		/// <returns>Instance of APIResponse<WriterResponseHandler></returns>
		public APIResponse<WriterResponseHandler> CreateDocumentPreview(PreviewParameters request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/writer/officeapi/v1/document/preview");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.ContentType="multipart/form-data";

			handlerInstance.Request=request;

			return handlerInstance.APICall<WriterResponseHandler>(typeof(WriterResponseHandler), "application/json");


		}

		/// <summary>The method to create watermark document</summary>
		/// <param name="request">Instance of WatermarkParameters</param>
		/// <returns>Instance of APIResponse<WriterResponseHandler></returns>
		public APIResponse<WriterResponseHandler> CreateWatermarkDocument(WatermarkParameters request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/writer/officeapi/v1/document/watermark");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.ContentType="multipart/form-data";

			handlerInstance.Request=request;

			return handlerInstance.APICall<WriterResponseHandler>(typeof(WriterResponseHandler), "application/json");


		}

		/// <summary>The method to create mail merge template</summary>
		/// <param name="request">Instance of MailMergeTemplateParameters</param>
		/// <returns>Instance of APIResponse<WriterResponseHandler></returns>
		public APIResponse<WriterResponseHandler> CreateMailMergeTemplate(MailMergeTemplateParameters request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/writer/officeapi/v1/templates");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.ContentType="multipart/form-data";

			handlerInstance.Request=request;

			return handlerInstance.APICall<WriterResponseHandler>(typeof(WriterResponseHandler), "application/json");


		}

		/// <summary>The method to get merge fields</summary>
		/// <param name="request">Instance of GetMergeFieldsParameters</param>
		/// <returns>Instance of APIResponse<WriterResponseHandler></returns>
		public APIResponse<WriterResponseHandler> GetMergeFields(GetMergeFieldsParameters request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/writer/officeapi/v1/fields");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.ContentType="multipart/form-data";

			handlerInstance.Request=request;

			return handlerInstance.APICall<WriterResponseHandler>(typeof(WriterResponseHandler), "application/json");


		}

		/// <summary>The method to merge and deliver via webhook</summary>
		/// <param name="request">Instance of MergeAndDeliverViaWebhookParameters</param>
		/// <returns>Instance of APIResponse<WriterResponseHandler></returns>
		public APIResponse<WriterResponseHandler> MergeAndDeliverViaWebhook(MergeAndDeliverViaWebhookParameters request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/writer/officeapi/v1/document/merge/webhook");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.ContentType="multipart/form-data";

			handlerInstance.Request=request;

			return handlerInstance.APICall<WriterResponseHandler>(typeof(WriterResponseHandler), "application/json");


		}

		/// <summary>The method to merge and download document</summary>
		/// <param name="request">Instance of MergeAndDownloadDocumentParameters</param>
		/// <returns>Instance of APIResponse<WriterResponseHandler></returns>
		public APIResponse<WriterResponseHandler> MergeAndDownloadDocument(MergeAndDownloadDocumentParameters request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/writer/officeapi/v1/document/merge");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.ContentType="multipart/form-data";

			handlerInstance.Request=request;

			return handlerInstance.APICall<WriterResponseHandler>(typeof(WriterResponseHandler), "application/json");


		}

		/// <summary>The method to create fillable template document</summary>
		/// <param name="request">Instance of CreateDocumentParameters</param>
		/// <returns>Instance of APIResponse<WriterResponseHandler></returns>
		public APIResponse<WriterResponseHandler> CreateFillableTemplateDocument(CreateDocumentParameters request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/writer/officeapi/v1/fillabletemplates");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.ContentType="multipart/form-data";

			handlerInstance.Request=request;

			return handlerInstance.APICall<WriterResponseHandler>(typeof(WriterResponseHandler), "application/json");


		}

		/// <summary>The method to create fillable link</summary>
		/// <param name="request">Instance of FillableLinkParameters</param>
		/// <returns>Instance of APIResponse<WriterResponseHandler></returns>
		public APIResponse<WriterResponseHandler> CreateFillableLink(FillableLinkParameters request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/writer/officeapi/v1/fillabletemplates/fillablelink");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.ContentType="multipart/form-data";

			handlerInstance.Request=request;

			return handlerInstance.APICall<WriterResponseHandler>(typeof(WriterResponseHandler), "application/json");


		}

		/// <summary>The method to convert document</summary>
		/// <param name="request">Instance of DocumentConversionParameters</param>
		/// <returns>Instance of APIResponse<WriterResponseHandler></returns>
		public APIResponse<WriterResponseHandler> ConvertDocument(DocumentConversionParameters request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/writer/officeapi/v1/document/convert");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.ContentType="multipart/form-data";

			handlerInstance.Request=request;

			return handlerInstance.APICall<WriterResponseHandler>(typeof(WriterResponseHandler), "application/json");


		}

		/// <summary>The method to compare document</summary>
		/// <param name="request">Instance of CompareDocumentParameters</param>
		/// <returns>Instance of APIResponse<WriterResponseHandler></returns>
		public APIResponse<WriterResponseHandler> CompareDocument(CompareDocumentParameters request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/writer/officeapi/v1/document/compare");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.ContentType="multipart/form-data";

			handlerInstance.Request=request;

			return handlerInstance.APICall<WriterResponseHandler>(typeof(WriterResponseHandler), "application/json");


		}

		/// <summary>The method to get all sessions</summary>
		/// <param name="documentid">string</param>
		/// <returns>Instance of APIResponse<WriterResponseHandler></returns>
		public APIResponse<WriterResponseHandler> GetAllSessions(string documentid)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/writer/officeapi/v1/documents/");

			apiPath=string.Concat(apiPath, documentid.ToString());

			apiPath=string.Concat(apiPath, "/sessions");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			return handlerInstance.APICall<WriterResponseHandler>(typeof(WriterResponseHandler), "application/json");


		}

		/// <summary>The method to get session</summary>
		/// <param name="sessionid">string</param>
		/// <returns>Instance of APIResponse<WriterResponseHandler></returns>
		public APIResponse<WriterResponseHandler> GetSession(string sessionid)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/writer/officeapi/v1/sessions/");

			apiPath=string.Concat(apiPath, sessionid.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			return handlerInstance.APICall<WriterResponseHandler>(typeof(WriterResponseHandler), "application/json");


		}

		/// <summary>The method to delete session</summary>
		/// <param name="sessionid">string</param>
		/// <returns>Instance of APIResponse<WriterResponseHandler></returns>
		public APIResponse<WriterResponseHandler> DeleteSession(string sessionid)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/writer/officeapi/v1/sessions/");

			apiPath=string.Concat(apiPath, sessionid.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			return handlerInstance.APICall<WriterResponseHandler>(typeof(WriterResponseHandler), "application/json");


		}

		/// <summary>The method to get document info</summary>
		/// <param name="documentid">string</param>
		/// <returns>Instance of APIResponse<WriterResponseHandler></returns>
		public APIResponse<WriterResponseHandler> GetDocumentInfo(string documentid)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/writer/officeapi/v1/documents/");

			apiPath=string.Concat(apiPath, documentid.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			return handlerInstance.APICall<WriterResponseHandler>(typeof(WriterResponseHandler), "application/json");


		}

		/// <summary>The method to delete document</summary>
		/// <param name="documentid">string</param>
		/// <returns>Instance of APIResponse<WriterResponseHandler></returns>
		public APIResponse<WriterResponseHandler> DeleteDocument(string documentid)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/writer/officeapi/v1/documents/");

			apiPath=string.Concat(apiPath, documentid.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			return handlerInstance.APICall<WriterResponseHandler>(typeof(WriterResponseHandler), "application/json");


		}

		/// <summary>The method to create sheet</summary>
		/// <param name="request">Instance of CreateSheetParameters</param>
		/// <returns>Instance of APIResponse<SheetResponseHandler></returns>
		public APIResponse<SheetResponseHandler> CreateSheet(CreateSheetParameters request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/sheet/officeapi/v1/spreadsheet");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.ContentType="multipart/form-data";

			handlerInstance.Request=request;

			return handlerInstance.APICall<SheetResponseHandler>(typeof(SheetResponseHandler), "application/json");


		}

		/// <summary>The method to create sheet preview</summary>
		/// <param name="request">Instance of SheetPreviewParameters</param>
		/// <returns>Instance of APIResponse<SheetResponseHandler></returns>
		public APIResponse<SheetResponseHandler> CreateSheetPreview(SheetPreviewParameters request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/sheet/officeapi/v1/spreadsheet/preview");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.ContentType="multipart/form-data";

			handlerInstance.Request=request;

			return handlerInstance.APICall<SheetResponseHandler>(typeof(SheetResponseHandler), "application/json");


		}

		/// <summary>The method to convert sheet</summary>
		/// <param name="request">Instance of SheetConversionParameters</param>
		/// <returns>Instance of APIResponse<SheetResponseHandler></returns>
		public APIResponse<SheetResponseHandler> ConvertSheet(SheetConversionParameters request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/sheet/officeapi/v1/spreadsheet/convert");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.ContentType="multipart/form-data";

			handlerInstance.Request=request;

			return handlerInstance.APICall<SheetResponseHandler>(typeof(SheetResponseHandler), "application/json");


		}

		/// <summary>The method to get sheet session</summary>
		/// <param name="sessionid">string</param>
		/// <returns>Instance of APIResponse<SheetResponseHandler></returns>
		public APIResponse<SheetResponseHandler> GetSheetSession(string sessionid)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/sheet/officeapi/v1/sessions/");

			apiPath=string.Concat(apiPath, sessionid.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			return handlerInstance.APICall<SheetResponseHandler>(typeof(SheetResponseHandler), "application/json");


		}

		/// <summary>The method to delete sheet session</summary>
		/// <param name="sessionid">string</param>
		/// <returns>Instance of APIResponse<SheetResponseHandler></returns>
		public APIResponse<SheetResponseHandler> DeleteSheetSession(string sessionid)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/sheet/officeapi/v1/session/");

			apiPath=string.Concat(apiPath, sessionid.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			return handlerInstance.APICall<SheetResponseHandler>(typeof(SheetResponseHandler), "application/json");


		}

		/// <summary>The method to delete sheet</summary>
		/// <param name="documentid">string</param>
		/// <returns>Instance of APIResponse<SheetResponseHandler></returns>
		public APIResponse<SheetResponseHandler> DeleteSheet(string documentid)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/sheet/officeapi/v1/spreadsheet/");

			apiPath=string.Concat(apiPath, documentid.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			return handlerInstance.APICall<SheetResponseHandler>(typeof(SheetResponseHandler), "application/json");


		}

		/// <summary>The method to create presentation</summary>
		/// <param name="request">Instance of CreatePresentationParameters</param>
		/// <returns>Instance of APIResponse<ShowResponseHandler></returns>
		public APIResponse<ShowResponseHandler> CreatePresentation(CreatePresentationParameters request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/show/officeapi/v1/presentation");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.ContentType="multipart/form-data";

			handlerInstance.Request=request;

			return handlerInstance.APICall<ShowResponseHandler>(typeof(ShowResponseHandler), "application/json");


		}

		/// <summary>The method to convert presentation</summary>
		/// <param name="request">Instance of ConvertPresentationParameters</param>
		/// <returns>Instance of APIResponse<ShowResponseHandler></returns>
		public APIResponse<ShowResponseHandler> ConvertPresentation(ConvertPresentationParameters request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/show/officeapi/v1/presentation/convert");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.ContentType="multipart/form-data";

			handlerInstance.Request=request;

			return handlerInstance.APICall<ShowResponseHandler>(typeof(ShowResponseHandler), "application/json");


		}

		/// <summary>The method to create presentation preview</summary>
		/// <param name="request">Instance of PresentationPreviewParameters</param>
		/// <returns>Instance of APIResponse<ShowResponseHandler></returns>
		public APIResponse<ShowResponseHandler> CreatePresentationPreview(PresentationPreviewParameters request)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/show/officeapi/v1/presentation/preview");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_POST;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.ContentType="multipart/form-data";

			handlerInstance.Request=request;

			return handlerInstance.APICall<ShowResponseHandler>(typeof(ShowResponseHandler), "application/json");


		}

		/// <summary>The method to get presentation session</summary>
		/// <param name="sessionid">string</param>
		/// <returns>Instance of APIResponse<ShowResponseHandler></returns>
		public APIResponse<ShowResponseHandler> GetPresentationSession(string sessionid)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/show/officeapi/v1/sessions/");

			apiPath=string.Concat(apiPath, sessionid.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			return handlerInstance.APICall<ShowResponseHandler>(typeof(ShowResponseHandler), "application/json");


		}

		/// <summary>The method to delete presentation session</summary>
		/// <param name="sessionid">string</param>
		/// <returns>Instance of APIResponse<ShowResponseHandler></returns>
		public APIResponse<ShowResponseHandler> DeletePresentationSession(string sessionid)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/show/officeapi/v1/session/");

			apiPath=string.Concat(apiPath, sessionid.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			return handlerInstance.APICall<ShowResponseHandler>(typeof(ShowResponseHandler), "application/json");


		}

		/// <summary>The method to delete presentation</summary>
		/// <param name="documentid">string</param>
		/// <returns>Instance of APIResponse<ShowResponseHandler></returns>
		public APIResponse<ShowResponseHandler> DeletePresentation(string documentid)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/show/officeapi/v1/presentation/");

			apiPath=string.Concat(apiPath, documentid.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_DELETE;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			return handlerInstance.APICall<ShowResponseHandler>(typeof(ShowResponseHandler), "application/json");


		}

		/// <summary>The method to get plan details</summary>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetPlanDetails()
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/api/v1/plan");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}


	}
}