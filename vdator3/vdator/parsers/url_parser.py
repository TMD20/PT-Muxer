from urllib.parse import urlparse
import re


class URLParser(object):
    def __init__(self, urls):
        # regex used to extract urls from message
        self.urls_regex = r"(?P<url>https?://[^\s]+)"

        """
        # hostname
        'example.com': {
            # regex to get paste's unique identifier
            'slug_regex': 'https://example.com/(.*)',
            
            # link to raw text using {} in place of the unique identifier
            'raw_url': 'https://example.com/raw/{}'
        }
        """
        self.urls = urls

    def extract_supported_urls(self, text):
        # list of urls
        urls = re.findall(self.urls_regex, text)
        raw_urls = list()
        for url in urls:
            o = urlparse(url)
            # check if url is supported
            if o.hostname in self.urls:
                raw_url = self.get_raw_url(url, o.hostname, o.path)
                raw_urls.append(raw_url)
        return raw_urls

    def get_raw_url(self, url, hostname, path):
        # get url to raw content
        raw_url = url

        # check if its not already a raw url
        is_already_raw_url = re.search(
            self.urls[hostname]["raw_url_regex"].format("(.*)"), url
        )

        if not is_already_raw_url:
            slug = re.search(self.urls[hostname]["slug_regex"], url)
            if slug:
                raw_url = self.urls[hostname]["raw_url"].format(slug.group(1))

        return raw_url

    def get_urls(self):
        return self.urls
