<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBusData.aspx.cs" Inherits="BusInfoAssignment.AddBusData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.1.3/dist/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous"/>
</head>
<body style="font-family: Arial, Helvetica, sans-serif; background-color: #afebeb">
    <h2 style="text-align: center; margin-top:2%; margin-bottom:1%;"><b>PKR TRAVELS</b></h2>
    <h3 style="text-align: center;">Add Bus Data</h3>
    <div style="margin-left:20%; margin-right:15%;">
    <form id="form1" runat="server">
        <div>
        </div>
        <div class="form-group row">
            <label for="BoardingPoint" class="col-sm-2 col-form-label-lg">Boarding Point</label>
            <div class="col-sm-10">
                <select class="custom-select">
                    <option value="" disabled="disabled" role="contentinfo">--Select--</option>
                    <option text="BGL" value="BGL">BGL</option>
                    <option text="HYD" value="HYD">HYD</option>
                    <option text="CHN" value="CHN">CHN</option>
                    <option text="PUN" value="PUN">PUN</option>
                    <option text="MUM" value="MUM">MUM</option>
                </select>
            </div>
        </div>
        <div class="form-group row">
            <label for="TravelDate" class="col-sm-2 col-form-label-lg">Travel Date</label>
            <div class="col-sm-10">
                <input type="date" class="form-control" id="TravelDate" />
            </div>
        </div>

        <div class="form-group row">
            <label for="Amount" class="col-sm-2 col-form-label-lg">Amount</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="Amount" placeholder="Enter Amount" />
            </div>
        </div>
        <div class="form-group row">
            <label for="Rating" class="col-sm-2 col-form-label-lg">Rating</label>
            <div class="col-sm-10">
                <input type="number" class="form-control" id="Rating" placeholder="Enter Rating" min="1" max="5" />
            </div>
        </div>


        <div class="form-group row">
            <div class="col-sm-2">
                <button type="submit" class="btn btn-outline-success">Add Bus Info</button>
            </div>
        </div>
    </form>
    </form>
    </div>
</body>
</html>
