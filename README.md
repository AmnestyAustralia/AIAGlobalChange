# AIAGlobalChange

AIAGlobalChange is a Blackbaud CRM feature pack containing global changes and related customisations for Amnesty International Australia.

## Project Structure

- **AIAGlobalChange** - Base customisation specs
- **AIAGlobalChangeUIModel** - UI model specs and HTML layout

## Customisations

### Global Changes

- **Make Constituent Inactive (AIA)** - Marks selected constituents as inactive with a specified reason and optional details. This global change updates the constituent's inactive status and creates or updates the associated inactivity detail record. Useful for processing deceased notifications, data hygiene tasks, or other scenarios requiring bulk inactivation.

- **Start User-Defined Constituency (AIA)** - "Starts" a user-defined constituency on a constituent record. This is similar to adding/deleting a constituency but uses the start and end date fields:
    * Constituents newly eligible for the constituency will have it added with today's date as the start date.
    * If a constituent with this constituency is no longer eligible it will optionally be updated with today's date as the end date.

- **Update Revenue Metadata (AIA)** - Updates marketing metadata fields (Source Code, Appeal, Mailing, and Channel) on revenue records. Only updates fields where a value is provided, leaving other fields unchanged. If a recurring gift record is updated a new "Edited" entry will be added to the recurring gift amendment history table.

- **Update Revenue Origin (AIA)** - Similar to 'Update Revenue Metadata (AIA)', but specifically targets the "Added" record in the recurring gift amendment history table to modify the original marketing metadata associated with a recurring gift. This is useful when the original recurring gift setup needs to be corrected for reporting.

- **Add Revenue Attribute (AIA)** - Adds custom attributes to revenue records.

- **Delete Revenue Attribute (AIA)** - Removes custom attributes from revenue records.

- **Add Random Attribute Value (AIA)** - Assigns random numeric values within a specified range to a single-valued numeric attribute across selected records, intended for use in testing setups (randomly assigning testing groups). Supports configurable minimum and maximum values.

### Smart Fields

- **Constituent Revenue Appeals (AIA)** - Returns the appeal associated with a constituent's earliest or latest revenue record filtered to a provided revenue selection, optionally excluding revenue records with blank appeals.
