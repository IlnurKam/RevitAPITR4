using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.Exceptions;
using Autodesk.Revit.UI;
using System;
using System.Resources;
using System.Windows.Forms;
using Application = Autodesk.Revit.ApplicationServices.Application;
using ArgumentNullException = System.ArgumentNullException;

namespace RevitAPITR4
{
    //[Transaction]
    public sealed class RoomNumerator : IExternalCommand
    {
        public object UIBuilder { get; private set; }

        Result IExternalCommand.Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            ResourceManager resourceManager1 = new ResourceManager(this.GetType());
            ResourceManager resourceManager2 = new ResourceManager(typeof(Resources));
            Result result = (Result) - 1;
            try
            {
                UIApplication application1 = commandData?.Application;
                UIDocument activeUiDocument = application1?.ActiveUIDocument;
                if (application1 != null)
                {
                    Application application2 = application1.Application;
                }
                using (TransactionGroup transactionGroup = new TransactionGroup(activeUiDocument?.Document, UIBuilder.GetResourceString(this.GetType(), typeof(Resources), "_transaction_group_name")))
                {
                    if (1 == transactionGroup.Start())
                    {
                        if (this.DoWork(commandData, ref message, elements))
                        {
                            if (3 == transactionGroup.Assimilate())
                                result = (Result)0;
                        }
                        else
                            transactionGroup.RollBack();
                    }
                }
            }
            catch (Autodesk.Revit.Exceptions.OperationCanceledException ex)
            {
                result = (Result) - 1;
            }
            catch (Exception ex)
            {
                TaskDialog.Show(resourceManager2.GetString("_Error"), ex.Message);
                result = (Result) - 1;
            }
            finally
            {
                resourceManager1.ReleaseAllResources();
                resourceManager2.ReleaseAllResources();
            }
            return result;
        }

        private bool DoWork(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            if (commandData == null)
                throw new ArgumentNullException(nameof(commandData));
            if (message == null)
                throw new ArgumentNullException(nameof(message));
            if (elements == null)
                throw new ArgumentNullException(nameof(elements));
            ResourceManager resourceManager1 = new ResourceManager(this.GetType());
            ResourceManager resourceManager2 = new ResourceManager(typeof(Resources));
            UIApplication application = commandData.Application;
            Document document = application?.ActiveUIDocument?.Document;
            string str = resourceManager1.GetString("_transaction_name");
            try
            {
                using (Transaction transaction = new Transaction(document, str))
                {
                    if (1 == transaction.Start())
                    {
                        RoomNum data = new RoomNum(application, document);
                        RoomNumeratorForm roomNumeratorForm = new RoomNumeratorForm(data);
                        DialogResult dialogResult = roomNumeratorForm.ShowDialog();
                        if (dialogResult == DialogResult.OK)
                            data.RenumRooms(document, BuiltInCategory);
                        while (dialogResult == DialogResult.Retry)
                        {
                            try
                            {
                                data.SelectRooms(application, document);
                            }
                            catch (Autodesk.Revit.Exceptions.OperationCanceledException ex)
                            {
                                throw;
                            }
                            finally
                            {
                                dialogResult = roomNumeratorForm.ShowDialog();
                                if (dialogResult == DialogResult.OK)
                                    data.RenumRooms(document, BuiltInCategory);
                            }
                        }
                        return 3 == transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                resourceManager1.ReleaseAllResources();
                resourceManager2.ReleaseAllResources();
            }
            return false;
        }
    }
}
