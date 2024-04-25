# SMS Sender from Excel

This application sends SMS messages using data extracted from an Excel file. It utilizes Twilio's SMS API to send messages where the phone numbers and templatized messages are specified in the Excel sheet.

## Features

- **Excel Integration**: Reads phone numbers and message templates from an Excel file.
- **Message Templating**: Supports dynamic message content filled based on Excel data.
- **Twilio API**: Uses Twilio for reliable SMS delivery.

## Prerequisites

Before you run this application, you need to have the following:

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 3.1 or later)
- A Twilio account with a verified phone number, SID, and Auth Token.
- An Excel file formatted as specified (see Excel File Format below).

## Excel File Format

The Excel file should follow this structure:

- **Column A**: Phone numbers
- **Column B**: Message template (e.g., "Happy Birthday <name>")
- **Column C onwards**: Values to replace in the template

Example:
| Phone Number | Message Template | Name |
|--------------|----------------------|--------|
| +1234567890 | Happy Birthday <name>| John |

## Setup

1. **Clone the repository**
   ```bash
   git clone [repository-url]
   cd [project-folder]
   ```
2. **Install Dependencies**

```dotnet restore
```

3. **Running the application \***

```dotnet run
```

### Notes on Customization:

- **Repository URL and Project Folder**: Replace `[repository-url]` and `[project-folder]` with your actual repository URL and local project folder name.
- **Twilio Credentials**: Make sure to securely handle your Twilio credentials; consider using environment variables or a configuration file for production environments.
- **License File**: If you decide to include a license, place the `LICENSE` file in your project root and reference it appropriately in the README.

This README template gives a clear overview of the project, how to set it up, and run it, along with guidelines for contributions and troubleshooting. Adjust any part of it to better fit your specific project requirements or additional features.
