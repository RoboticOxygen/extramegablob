﻿namespace ExtraMegaBlob.References
{
    public enum EventTransfer
    {
        CLIENTTOCLIENT,
        CLIENTTOSERVER,
        SERVERTOCLIENT,
        SERVERTOSERVER,
        TRASH
    }

    public enum eventScope
    {
        NIL,//consume
        CLIENTALL,
        CLIENTSPECIFY, //client side AllowedOutputNames
        SERVERALL,
        SERVERSPECIFY
    }
    //public struct eventIntendedRecipients
    //[FlagsAttribute]
    enum MultiHue : short
    {
        Black = 0,
        Red = 1,
        Green = 2,
        Blue = 4
    };
    
    public enum KeyWord
    {
        DATA_QUATERNION_W,
        DATA_QUATERNION_X,
        DATA_QUATERNION_Y,
        DATA_QUATERNION_Z,
        DATA_VECTOR3_X,
        DATA_VECTOR3_Y,
        DATA_VECTOR3_Z,
        DATA_STRING,
        PLAYER_RESET,

        NIL,
        MOVEPLAYER,
        ROTATEPLAYER,
        PREVENTMOUSEPICK,

        CACHE_CLIENTDELETEFILE,
        CACHE_CLIENTREPORT,
        CACHE_CLIENTUPDATEFILE,
        CACHE_CLIENTRENAMEFILE,

        CMD_GO,

        CAMCAP,
        CAMCAP_JPG,

        PLAYER_UNFREEZE,
        PLAYER_FREEZE,
        TONGITS_CARD_DATA,
        TONGITS_CARD_DECK_PLACE,
        TONGITS_GAME_STARTING,
        TONGITS_PLAYER_NUMBER,
        TONGITS_PLAYER_INVITE_ACCEPTED,
        TONGITS_PLAYER_INVITE,
        TONGITS_PLAYERLOCATION_UPDATE,

        ADDZELBOX,
        //new ones
        UPDATE_LOCATIONXY,
        TESTLOOP,

        //states
        STATE_BROADCASTING,
        STATE_BUG,
        STATE_BUSY,
        STATE_CONSTRUCTED,
        STATE_CONSTRUCTING,
        STATE_DESTROYED,
        STATE_DESTROYING,
        STATE_GREEN,
        STATE_LISTENING,
        STATE_MALFUNCTION,
        STATE_PAUSED,
        STATE_READY,
        STATE_RED,
        STATE_YELLOW,
        STATE_CLOSED,

        //event flags
        EVENT_DELIVERED_ARCHIVED,
        EVENT_DELIVERED_UNARCHIVED,
        EVENT_UNDELIVERED_ARCHIVED,
        EVENT_UNDELIVERED_UNARCHIVED,

        //others
        EVENT_DEF_UPDATE,
        EVENT_DEF_NEW,
        EVENT_DEF_DELETE,

        DEF,
        DEF_NAME,
        DEF_IMPORTANCE,
        DEF_MODULES,
        DEF_NOTES,

        DEF_AIML_DEFAULTPREDICATES,
        DEF_AIML_GENDERSUBSTITUTIONS,
        DEF_AIML_PERSON2SUBSTITUTIONS,
        DEF_AIML_PERSONSUBSTITUTIONS,
        DEF_AIML_SETTINGS,
        DEF_AIML_SPLITTERS,
        DEF_AIML_SUBSTITUTIONS,

        EVENT_STATE_CHANGED,
        EVENT_LOG,
        EVENT_SAVEALL,
        EVENT_CONFIG_FROM,
        EVENT_CONFIG_TO,

        EVENT_CHATMESSAGE,
        EVENT_RAWMESSAGE,
        EVENT_INTERFACE_STREAM,
        EVENT_INTERFACE_STATS_UPDATED,
        EVENT_INTERFACE_GLIDE_STOP,
        EVENT_INTERFACE_GLIDE_START,



        COMPONENT_INTERFACE,
        COMPONENT_GUI,
        COMPONENT_ARCHIVE,
        COMPONENT_CORE,
        COMPONENT_COMPILER,
        COMPONENT_AIML,
        COMPONENT_PROFILE,
        COMPONENT_PROFILE_DEBUG,


        CONSOLE_ACCESS_TRUE,
        CONSOLE_ACCESS_FALSE,
        IMPORTANCE_0_CRITICAL,
        IMPORTANCE_1_INTEGRAL,
        IMPORTANCE_2_NORMAL,
        IMPORTANCE_3_WEAK,
        IMPORTANCE_4_TRASH,
        CHATMESSAGE,
        CHATMESSAGE_PLAYER_FROM,
        CHATMESSAGE_PLAYER_TO,
        CHATMESSAGE_MESSAGE,
        CHATMESSAGE_CHANNEL,
        CHATMESSAGE_WHEN,
        RAWMESSAGE,
        RAWMESSAGE_MESSAGE,
        RAWMESSAGE_WHEN,

        //commands
        GUI_ADDMODULE,
        GUI_DELMODULE,

        //controls
        GUI_CONTROL_RICHTEXTBOX,
        GUI_CONTROL_BUTTON,
        GUI_CONTROL_GROUPBOX,
        GUI_CONTROL_TABCONTROL,
        GUI_CONTROL_TREEVIEW,
        GUI_CONTROL_TREEVIEWITEM,
        GUI_CONTROL_TABPAGE,
        GUI_CONTROL_COMBOBOX,
        GUI_CONTROL_CHECKBOX,
        GUI_CONTROL_LISTBOX,
        GUI_CONTROL_CHECKEDLISTBOX,
        GUI_CONTROL_TEXTBOX,
        GUI_CONTROL_TEXTBOXPASSWORD,
        GUI_CONTROL_LABEL,

        GUI_CONTROL_ADD,
        GUI_CONTROL_DELETE,
        GUI_CONTROL_MOD,

        //EVENTS
        GUI_EVENT_RAW,
        GUI_EVENT_CLICK,
        GUI_EVENT_MOUSEDOUBLECLICK,
        GUI_EVENT_KEYDOWN,
        GUI_EVENT_TEXTCHANGED,
        GUI_EVENT_FORMSHOWN,
        GUI_EVENT_FORMCLOSED,
        GUI_EVENT_SELECTEDINDEXCHANGED,

        GUI_COMMAND_ITEM_ADD,
        GUI_COMMAND_ITEM_DEL,
        GUI_COMMAND_ITEM_CLEARALL,
        GUI_COMMAND_ITEM_CLEARONE,

        //COMMON FIELDS
        GUI_COMMONFIELDS_NAME,
        GUI_COMMONFIELDS_TEXT,
        GUI_COMMONFIELDS_ANCHOR,
        GUI_COMMONFIELDS_ENABLED,
        GUI_COMMONFIELDS_TYPE,

        GUI_COMMONFIELDS_TABINDEX,
        GUI_COMMONFIELDS_POS_X,
        GUI_COMMONFIELDS_POS_Y,
        GUI_COMMONFIELDS_SIZE_X,
        GUI_COMMONFIELDS_SIZE_Y,
        GUI_COMMONFIELDS_PARENT_NAME,

        //MODULE EVENTS
        EVENT_MODULE_ERROR,
        EVENT_MODULE_ERROR_PARSE,

        CARTESIAN_SECRETPLAYERLOCATION,
        CARTESIAN_X,
        CARTESIAN_Y,
        CARTESIAN_Z

    }
    public enum LIGHTS
    {
        OFF,
        GREEN,
        YELLOW,
        RED,
        NONE
    }
    public enum SMALLSQUARES
    {
        YELLOW,
        GREEN,
        RED,
    }
}