curl -X POST \
https://api.mailersend.com/v1/email \
-H 'Content-Type: application/json' \
-H 'X-Requested-With: XMLHttpRequest' \
-H 'Authorization: Bearer mlsn.fbffcfd83e0d0d1fdae55c63061cd045168ea43b1f70e7b0717d43cee6abddf1' \
-d '{
    "from": {
        "email": "dannyKentala22@trial-z86org8o1d04ew13.mlsender.net"
    },
    "to": [
        {
            "email": "handres41@outlook.com"
        }
    ],
    "subject": "Hello from MailerSend!",
    "text": "Greetings from the team, you got this message through MailerSend.",
    "html": "Greetings from the team, you got this message through MailerSend."
}'