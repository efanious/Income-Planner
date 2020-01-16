using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Income_Planner
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        //Referencing the Edittext views
        EditText incomePerHourEditText;
        EditText workHourPerDayEditText;
        EditText taxRateEditText;
        EditText savingRateEditText;

        TextView workSummaryTextView;
        TextView grossIncomeTextView;
        TextView taxPayableTextView;
        TextView annualSavingsTextView;
        TextView spendableIncomeTextView;

        Button calculateButton;
        RelativeLayout resultLayout;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
        

        void ConnectViews()
        {
            incomePerHourEditText = FindViewById<EditText>(Resource.Id.incomePerHourEditText);
            workHourPerDayEditText = (EditText)FindViewById(Resource.Id.workHoursEditText);
            taxRateEditText = (EditText)FindViewById(Resource.Id.taxRateEditText);
            savingRateEditText = (EditText)FindViewById(Resource.Id.savingsRateEditText);

            workSummaryTextView = (TextView)FindViewById(Resource.Id.workSummaryTextView);
            grossIncomeTextView = (TextView)FindViewById(Resource.Id.grossIncomeTextView);
            taxPayableTextView = (TextView)FindViewById(Resource.Id.annualTaxPayableTextView);
            annualSavingsTextView = (TextView)FindViewById(Resource.Id.annualSavingsTextView);
            spendableIncomeTextView = (TextView)FindViewById(Resource.Id.spendableIncomeTextView);

            calculateButton = (Button)FindViewById(Resource.Id.calculateButton);
            resultLayout = (RelativeLayout)FindViewById(Resource.Id.resultLayout);

        }

    }
}